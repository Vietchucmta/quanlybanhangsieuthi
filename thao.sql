
-- thêm chi tiết xuất kho
alter proc proc_chitietxuat(@maxuat nvarchar(20),@mamathang nvarchar(20),@soluong int)
as
begin
	declare @gia float
	declare @dongia float
	declare @tonggiatri float
	select @gia=mh.gia from mathang mh inner join
	chitietphieuxuat b on mh.ma=b.mamathang where b.mamathang=@mamathang
	select @dongia=@gia*@soluong
	insert into chitietphieuxuat(maxuat,mamathang,soluong,dongia)
	values (@maxuat,@mamathang,@soluong,@dongia)
	select @tonggiatri=a.dongia from (select maxuat,dongia=sum(dongia) from chitietphieuxuat where maxuat=@maxuat group by maxuat ) a
	update phieuxuatkho set tonggiatri=@tonggiatri where phieuxuatkho.ma=@maxuat
end
exec proc_chitietxuat '001','01',10
select * from chitietphieuxuat
select * from phieuxuatkho
-- sửa chi tiết phiếu xuất 
alter proc proc_upchitietxuat(@stt int,@maxuat nvarchar(20),@mamathang nvarchar(20),@soluong int)
as
begin
	declare @gia float
	declare @dongia float
	declare @tonggiatri float
	select @gia=mh.gia from mathang mh inner join
	chitietphieuxuat b on mh.ma=b.mamathang where b.mamathang=@mamathang
	select @dongia=@gia*@soluong
	update chitietphieuxuat set maxuat=@maxuat,mamathang=@mamathang,soluong=@soluong,dongia=@dongia
	where stt=@stt
	select @tonggiatri=a.dongia from (select maxuat,dongia=sum(dongia) from chitietphieuxuat where maxuat=@maxuat group by maxuat ) a
	update phieuxuatkho set tonggiatri=@tonggiatri where phieuxuatkho.ma=@maxuat
end

exec proc_upchitietxuat 9,'001','01',20

-- delete chi tiết phiếu xuất
create proc proc_dechitietxuat(@stt int)
as
begin
	declare @maxuat nvarchar(20)
	declare @tonggiatri float
	select @maxuat=ct.maxuat from chitietphieuxuat ct where ct.stt=@stt
	delete chitietphieuxuat where stt=@stt
	select @tonggiatri=a.dongia from (select maxuat,dongia=sum(dongia) from chitietphieuxuat where maxuat=@maxuat group by maxuat ) a
	update phieuxuatkho set tonggiatri=@tonggiatri where phieuxuatkho.ma=@maxuat
end

exec proc_dechitietxuat 9