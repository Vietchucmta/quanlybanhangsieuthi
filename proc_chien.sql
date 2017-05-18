-- thêm chi tiết hóa đơn
alter proc proc_giatien(@mahoadon nvarchar(20),@mamathang nvarchar(20),@soluong int)
as
begin
	declare @gia float
	declare @dongia float
	declare @tonggiatri float
	declare @thanhtien float
	declare @uudai float 
	select @gia=mh.gia from mathang mh inner join
	chitiethoadon ct on mh.ma=ct.mamathang where ct.mamathang=@mamathang 
	select @dongia=@gia*@soluong 
	insert into chitiethoadon(mahoadon,mamathang,soluong,dongia)
	values(@mahoadon,@mamathang,@soluong,@dongia)

	select @uudai=kh.uudai from khachhang kh inner join hoadon hd on hd.makhachhang=kh.ma where hd.ma=@mahoadon
	select  @tonggiatri=dt.dongia from (select mahoadon,dongia=sum(dongia) from chitiethoadon ct where mahoadon=@mahoadon group by mahoadon) dt 
	select @thanhtien=@tonggiatri -@tonggiatri*@uudai from hoadon where hoadon.ma=@mahoadon
	update hoadon set tonggiatri=@tonggiatri,thanhtien=@thanhtien where hoadon.ma=@mahoadon
end

exec proc_giatien '006','02',3

-- cập nhập chi tiết hóa đơn
alter proc proc_updateCtHd(@mahoadon nvarchar(20),@mamathang nvarchar(20),@soluong int,@stt int)
as
begin
	declare @gia float
	declare @dongia float
	declare @tonggiatri float
	declare @thanhtien float
	declare @uudai float 
	select @gia=mh.gia from mathang mh inner join
	chitiethoadon ct on mh.ma=ct.mamathang where ct.mamathang=@mamathang 
	select @dongia=@gia*@soluong
	update chitiethoadon set mahoadon=@mahoadon,mamathang=@mamathang,soluong=@soluong,
	dongia=@dongia where stt=@stt

	select @uudai=kh.uudai from khachhang kh inner join hoadon hd on hd.makhachhang=kh.ma where hd.ma=@mahoadon
	select  @tonggiatri=dt.dongia from (select mahoadon,dongia=sum(dongia) from chitiethoadon ct where mahoadon=@mahoadon group by mahoadon) dt 
	select @thanhtien=@tonggiatri -@tonggiatri*@uudai
	update hoadon set tonggiatri=@tonggiatri,thanhtien=@thanhtien where hoadon.ma=@mahoadon
end

exec proc_updateCtHd '005','02',2,1

