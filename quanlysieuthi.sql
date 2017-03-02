
/*1*/
create table quayhang(
	ma nvarchar(20) primary key,
	ten nvarchar(50) not null
)
/*2*/
create table mathang(
	ma nvarchar(20) primary key,
	ten nvarchar(50) not null,
	loaimathang nvarchar(50) null,
	donvitinh nvarchar(10) null,
	maquay nvarchar(20) foreign key(maquay) references quayhang(ma)
	)

/*3*/
create table nhacungcap(
	ma nvarchar(20) primary key,
	ten nvarchar(100)not null,
	diachi nvarchar(200) ,
	sodienthoai nvarchar(15),
	email nvarchar(50)
)
/*4*/
create table chucvu(
	ma nvarchar(20) primary key,
	ten nvarchar(50) not null
)
/*5*/
create table nhanvien(
	ma nvarchar(20) primary key,
	ten nvarchar(50) not null,
	ngaysinh datetime ,
	diachi nvarchar(200),
	sodienthoai nvarchar(15),
	machucvu nvarchar(20) foreign key (machucvu) references chucvu(ma)
)
/*6*/
create table khohang(
	ma nvarchar(20) primary key,
	ten nvarchar(50) not null,
	diachi nvarchar(200)
)
/*7*/
create table phieugiaoca(
	ma nvarchar(20) primary key,
	ngay datetime,
	ca int,
	maquay nvarchar(20) foreign key(maquay) references quayhang(ma),
	manhanvien nvarchar(20) foreign key(manhanvien) references nhanvien(ma)
)

/*8*/
create table chitietphieugiaoca(
	stt int identity primary key,
	magiaoca nvarchar(20) foreign key(magiaoca) references phieugiaoca(ma),
	mamathang nvarchar(20) foreign key(mamathang) references mathang(ma),
	soluong int 
)

/*9*/
create table phieunhapkho(
	ma nvarchar(20) primary key,
	makhohang nvarchar(20) foreign key(makhohang) references khohang(ma),
	ngaynhap datetime,
	tonggiatri float ,
	manhacungcap nvarchar(20) foreign key(manhacungcap) references nhacungcap(ma),
	manhanvien nvarchar(20) foreign key(manhanvien) references nhanvien(ma)
)
/*10*/
create table chitiepphieunhap(
	stt int identity primary key,
	manhap nvarchar(20) foreign key(manhap) references phieunhapkho(ma),
	mamathang nvarchar(20) foreign key(mamathang) references mathang(ma),
	soluong int,
	dongia float
)

/*11*/
create table phieuxuatkho(
	ma nvarchar(20) primary key,
	ngayxuat datetime,
	tonggiatri float,
	makhohang nvarchar(20) foreign key(makhohang) references khohang(ma),
	manhanvien nvarchar(20) foreign key(manhanvien) references nhanvien(ma),
	maquay nvarchar(20) foreign key(maquay) references quayhang(ma),
)

/*12*/
create table chitietphieuxuat(
	stt int identity primary key,
	maxuat nvarchar(20) foreign key (maxuat) references phieuxuatkho(ma),
	mamathang nvarchar(20) foreign key(maxuat) references mathang(ma),
	soluong int
) 
/*

/*13*/
create table phieudathang(
	ma nvarchar(20) primary key,
	ngaydathang datetime,
	diachinhan nvarchar(200),
	sodienthoai nvarchar(15),
	manhanvien nvarchar(20) foreign key(manhanvien) references nhanvien(ma)
)

/*14*/
create table chitietphieudathang(
	stt int identity primary key,
	madathang nvarchar(20) foreign key(madathang) references phieudathang(ma),
	mamathang nvarchar(20) foreign key(mamathang) references mathang(ma),
	soluong int,
	dongia float
)
/*15*/
create table phieugiaohang(
	ma nvarchar(20) primary key,
	ngaygiao datetime,
	diachigiao nvarchar(200),
	sodienthoai nvarchar(15),
	thanhtien float,
	manhanvien nvarchar(20) foreign key(manhanvien) references nhanvien(ma)
)
/*16*/
create table chitietphieugiaohang(
	stt int identity primary key,
	magiaohang nvarchar(20) foreign key (magiaohang) references phieugiaohang(ma),
	mamathang nvarchar(20) foreign key(mamathang) references mathang(ma),
	soluong int,
	dongia float
)
*/

/*17*/
create table phieukiemke(
	ma nvarchar(20) primary key,
	ngaylap datetime,
	mamathang nvarchar(20) foreign key(mamathang) references mathang(ma),
	soluong int,
	manhanvien nvarchar(20) foreign key(manhanvien) references nhanvien(ma),
	makhohang nvarchar(20) foreign key(makhohang) references khohang(ma)
)
/*18*/
create table hoadon(
	ma nvarchar(20) primary key,
	ngaylap datetime,
	mamathang nvarchar(20) foreign key(mamathang) references mathang(ma),
	tonggiatri float,
	thanhtien float,
	manhanvien nvarchar(20) foreign key(manhanvien) references nhanvien(ma)
)
/*19*/

create table chitiethoadon(
	stt int identity primary key,
	mahoadon nvarchar(20) foreign key(mahoadon) references hoadon(ma),
	mamathang nvarchar(20) foreign key(mamathang) references mathang(ma),
	soluong int,
	dongia float
)
/*20*/
create table khachhang(
	ma nvarchar(20) primary key,
	ten nvarchar(50) not null,
	diachi nvarchar(200),
	sodienthoai nvarchar(15),
	uudai float
)

/*21*/
create table khachmuahang(
	stt int identity primary key,
	makhachhang nvarchar(20) foreign key(makhachhang) references khachhang(ma),
	mahoadon nvarchar(20) foreign key (mahoadon) references hoadon(ma)
)
/*22*/
create table quaythungan(
	ma int identity primary key,
	ten nvarchar(20) not null,
	mahoadon nvarchar(20) foreign key (mahoadon) references hoadon(ma)
)