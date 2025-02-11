create database ResManager;
use ResManager;

create table StaffPos(
	id_pos int primary key,
	posName varchar(50)
	);
	
	
create table staff (
	staff_id int primary key,
	staffName varchar(50) not null,
	DoB date,
	staffPhone varchar(10) not null,
	idPosition int FOREIGN KEY REFERENCES StaffPos(id_pos),
	staffState int not null,
	bonus int ,
	totalSal bigint 
);


	
select * from staff;
insert into StaffPos values(1,'Chef');
insert into staff(staff_id,staffName,staffPhone,idPosition,staffState) values(1000,'Nguyen Duy Khang','0568812099',1,1)

create table tables (
	table_id int identity(1,1) primary key,
	tableName varchar(15) not null,
	num_of_seat int not null,
	tableState int not null
);

create table invoice(
	invoice_id bigint identity(1,1) primary key,
	table_id int FOREIGN KEY REFERENCES tables(table_id) not null,
	staff_id int FOREIGN KEY REFERENCES staff(staff_id) not null,
	invoiceDate datetime not null,
	invoiceDateUpt datetime not null,
	invoiceTotal bigint not null,
	invoiceState int not null,
	
);


create table dish_category(
	cate_id int identity(1,1) primary key,
	CateName varchar(50) not null
);

create table dish_menu(
	dish_id int primary key,
	dishName varchar(50) not null,
	cate_id int FOREIGN KEY REFERENCES dish_category(cate_id) not null,
	price int not null,
	unit varchar(15),
	dishState int not null
);

create table invoice_detail(
	invoice_id bigint FOREIGN KEY REFERENCES invoice(invoice_id) not null,
	dish_id int FOREIGN KEY REFERENCES dish_menu(dish_id) not null,
	Quantity int not null
);
drop table invoice_detail;

select * from dish_category;


create table accounts(
	accID int identity(1,1) primary key,
	uname varchar(32) not null,
	passwd varchar(32) not null,
	acctype int not null,
);

insert into accounts(uname,passwd,acctype) values ('ndkhang','ndkhang',1);
select * from accounts;


----------------------MENU/TABLE--------------------------
drop table dish_category;
drop table dish_menu;


-- --DISH
-- Table dish category
/*
	Danh mục của các món ăn, các món ăn sẽ thuộc 1 danh mục riêng
*/
create table dish_category(
	cate_id int IDENTITY,
    CateName nvarchar(50) not null unique,
    primary key(cate_id)
);

insert into dish_category(CateName) values(N'Gà/Vịt');
insert into dish_category(CateName) values(N'Bò/Heo');
insert into dish_category(CateName) values(N'Thủy/Hải sản');
insert into dish_category(CateName) values(N'Lẩu');
insert into dish_category(CateName) values(N'Cơm/Mì');
insert into dish_category(CateName) values(N'Soup');
insert into dish_category(CateName) values(N'Tráng miệng/Nước');
insert into dish_category(CateName) values(N'Khác');
select * from dish_category;
/*
	Danh sách món ăn
	dishState 1: còn bán, 0: hết bán
*/
create table dish_menu(
	dish_id int IDENTITY,
    dishName nvarchar(50) not null,
    cate_id int,
    price int not null,
    unit nvarchar(15) not null,
	dishState int default 1,
    primary key(dish_id),
    constraint fk_dish_menu_cate_id foreign key(cate_id) references dish_category(cate_id),
    constraint ck_dish_menu_price check (price >= 0)
);

insert into dish_menu(dishName, cate_id, price, unit,dishState) values(N'Cá Chẽm Chiên Giòn', 3, 260000, N'con',1);
insert into dish_menu(dishName, cate_id, price, unit,dishState) values(N'Cá Chẽm Hấp', 3, 260000, N'con',1);
insert into dish_menu(dishName, cate_id, price, unit,dishState) values(N'Cá Dứa Chiên', 3, 100000, N'con',1);
insert into dish_menu(dishName, cate_id, price, unit,dishState) values(N'Cá Bớp Chiên', 3, 100000, N'con',1);
insert into dish_menu(dishName, cate_id, price, unit,dishState) values(N'Lẩu Cá Chẽm', 4, 260000, N'phần',1);
insert into dish_menu(dishName, cate_id, price, unit,dishState) values(N'Cá Đuối Hấp', 3, 200000, N'con',1);
insert into dish_menu(dishName, cate_id, price, unit,dishState) values(N'Cơm Chiên Hến', 5, 60000, N'phần',1);
insert into dish_menu(dishName, cate_id, price, unit,dishState) values(N'Cơm Chiên Cá Mặn', 5, 70000, N'phần',1);
insert into dish_menu(dishName, cate_id, price, unit,dishState) values(N'Cơm Chiên Hoàng Bào', 5, 70000, N'phần',1);
insert into dish_menu(dishName, cate_id, price, unit,dishState) values(N'Cơm Chiên Dương Châu', 5, 50000, N'phần',1);
insert into dish_menu(dishName, cate_id, price, unit,dishState) values(N'Mì Xào Bò', 5, 55000, N'phần',1);
insert into dish_menu(dishName, cate_id, price, unit,dishState) values(N'Mì Xào GIòn', 5, 50000, N'phần',0);
insert into dish_menu(dishName, cate_id, price, unit,dishState) values(N'Mì Xào Hải Sản', 5, 60000, N'phần',1);
insert into dish_menu(dishName, cate_id, price, unit,dishState) values(N'Lẩu Thái Hải Sản', 4, 150000, N'phần',1);
insert into dish_menu(dishName, cate_id, price, unit,dishState) values(N'Lẩu Nấm', 4, 100000, N'phần',1);
insert into dish_menu(dishName, cate_id, price, unit,dishState) values(N'Gà Luộc', 1, 160000, N'con',0);
insert into dish_menu(dishName, cate_id, price, unit,dishState) values(N'Gà Quay', 1, 160000, N'con',1);
insert into dish_menu(dishName, cate_id, price, unit,dishState) values(N'Gà Nướng Muối Ớt', 1, 170000, N'con',1);
insert into dish_menu(dishName, cate_id, price, unit,dishState) values(N'Bò Quanh Lửa Hồng', 2, 120000, N'phần',0);
insert into dish_menu(dishName, cate_id, price, unit,dishState) values(N'Bò Tái Chanh', 2, 100000, N'phần',1);
insert into dish_menu(dishName, cate_id, price, unit,dishState) values(N'Soup Thập Cẩm', 6, 50000, N'phần',1);
insert into dish_menu(dishName, cate_id, price, unit,dishState) values(N'Soup Cua', 6, 70000, N'phần',0);
insert into dish_menu(dishName, cate_id, price, unit,dishState) values(N'Nước Ngọt Các Loại', 7, 15000, N'chai/lon',1);
insert into dish_menu(dishName, cate_id, price, unit,dishState) values(N'Trái Cây Dĩa', 7, 40000, N'dĩa',1);
insert into dish_menu(dishName, cate_id, price, unit,dishState) values(N'Bia', 7, 20000, N'chai/lon',1);

-- --TABLES
/*
	Danh sách bàn
	tableState 1: đang có người ngồi, 0: đang trống
*/
create table tables(
	table_id int identity,
    tableName nvarchar(15) unique,
    num_of_seat int default 0,
    tableState int default 0,
    primary key(table_id)
);

insert into tables(tableName, num_of_seat) values(N'Mang Về', 0);
insert into tables(tableName, num_of_seat) values(N'Bàn 01', 4);
insert into tables(tableName, num_of_seat) values(N'Bàn 02', 4);
insert into tables(tableName, num_of_seat) values(N'Bàn 03', 4);
insert into tables(tableName, num_of_seat) values(N'Bàn 04', 4);
insert into tables(tableName, num_of_seat) values(N'Bàn 05', 10);
insert into tables(tableName, num_of_seat) values(N'Bàn 06', 10);
insert into tables(tableName, num_of_seat) values(N'Bàn 07', 4);
insert into tables(tableName, num_of_seat) values(N'Bàn 08', 4);
insert into tables(tableName, num_of_seat) values(N'Bàn 09', 4);
insert into tables(tableName, num_of_seat) values(N'Bàn 10', 4);
insert into tables(tableName, num_of_seat) values(N'Bàn 11', 4);
insert into tables(tableName, num_of_seat) values(N'Bàn 12', 10);
insert into tables(tableName, num_of_seat) values(N'Bàn 13', 10);
insert into tables(tableName, num_of_seat) values(N'Bàn 14', 4);
insert into tables(tableName, num_of_seat) values(N'Bàn 15', 4);
insert into tables(tableName, num_of_seat) values(N'Bàn 16', 4);
insert into tables(tableName, num_of_seat) values(N'Bàn 17', 4);
insert into tables(tableName, num_of_seat) values(N'Bàn 18', 4);
insert into tables(tableName, num_of_seat) values(N'Bàn 19', 4);
insert into tables(tableName, num_of_seat) values(N'Bàn 20', 4);
insert into tables(tableName, num_of_seat) values(N'Bàn 21', 4);

/*thêm 1 danh mục món ăn*/
create procedure dish_cate_new(@CateName nvarchar(50))
as
begin
    if not exists(select CateName from dish_category where upper(dish_category.CateName)=upper(@CateName))
    begin
        insert into dish_category(CateName) values(@CateName);
	end
end
--execute dish_cate_new 'Bánh ngọt';

/*Danh sách danh mục thức ăn*/
create function list_category()
returns @temptable table (
	cate_id int,
	CateName nvarchar(50)
)
as
begin
	insert into @temptable
	select * from dish_category order by cate_id;
	return;
end
--select * from list_category();
drop function dish_list_by_cate;
/*trả về danh sách món ăn theo danh mục*/
create function dish_list_by_cate(@cateid int)
	returns @temptable table (
		dish_id int,
		dishName nvarchar(50),
		price int,
		unit nvarchar(50),
		state nvarchar(50),
		cateid int
	)
as
begin
	if exists (select dish_id from dish_menu where dishState=1)
	begin
		insert into @temptable
		select dish_id, dishName, price, unit,
        case when dm.dishState=1
			then'Available'
		else 'Deleted' end as state, @cateid
        from dish_menu dm join dish_category dc on dm.cate_id=dc.cate_id where dm.cate_id=@cateid
        and dm.dishState=1
		order by dish_id asc;
    end
    return
end
--select * from dish_list_by_cate(3);

/*trả về danh sách các món không còn bán nữa*/
create function dish_list_deleted()
	returns @temptable table (
		dish_id int,
		dishName nvarchar(50),
		cateName nvarchar(50),
		price int,
		unit nvarchar(50),
		state nvarchar(10)
	)
as
begin
	if exists (select dish_id from dish_menu where dishState=0)
	begin
		insert into @temptable
		select dish_id, dishName, cateName, price, unit, 'Deleted' as state
        from dish_menu dm join dish_category dc on dm.cate_id=dc.cate_id
        where dishState=0
		order by dish_id asc;
    end
    return
end

--select * from dish_list_deleted();

select * from tables;


/*Thêm 1 bàn mới*/
create procedure table_new(@tableName nvarchar(15), @num_of_seat int)
as
begin
    if not exists (select table_id from tables where tables.tableName=@tableName)
	begin
		insert into tables(tableName, num_of_seat) values(@tableName,@num_of_seat);
    end;
end
--execute table_new N'Bàn 22', 4;


/*Danh sách tất cả các bàn*/
create function table_list()
returns table
as
	return
	select * from tables;
--select * from table_list();


/*Thêm 1 món ăn*/
create procedure dish_new(@dishName nvarchar(50), @cateid int,
							@price int, @unit nvarchar(15))
as
begin
	insert into dish_menu(dishName, cate_id, price, unit) values(@dishName,@cateid,@price,@unit);
end

select * from dish_menu;


/*Cập nhật thông tin món ăn*/
create procedure dish_update(@dish_id int, @dishName nvarchar(50), @vcate_id int,
									@price int, @unit nvarchar(15))
as
begin
	if exists (select dish_id from dish_menu dm where dm.dish_id=@dish_id and dm.dishState=1)
	begin
		update dish_menu set dishName=@dishName, cate_id=@vcate_id, price=@price, unit=@unit
        where dish_id=@dish_id;
	end
end
