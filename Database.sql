
create table UserTable (
    id int IDENTITY(1,1) PRIMARY KEY,
    username VARCHAR(30),
    email varchar(30),
    firstName Nvarchar(30),
    lastName Nvarchar(30),
    pwd varchar(30),
    gender Nvarchar(3),
    birth varchar(10),
    city Nvarchar(30),
) 

go
CREATE PROCEDURE SelectUserCountry @city nvarchar(30)
AS
SELECT * FROM UserTable WHERE city = @city
GO

insert into UserTable values
('trongtinh7727','tinhne@app.com',N'Võ Trọng', N'Tình','admin','nam','08/08/2003',N'Long An'),
('admin','admin@app.com',N'Võ Trọng', N'Tình','admin','nam','08/08/2003',N'TP.HCM'),
('pucle','pucle@app.com',N'Lê Hoàng', N'Púc','admin','nam','08/08/2003',N'Vũng Tàu'),
('dunga','dungx@app.com',N'Nguyễn', N'Dũng','admin','nam','08/08/2003',N'Vũng Tàu'),
('gamne','green@app.com',N'Nguyễn Thị Hồng', N'Gấm','admin','nam','08/08/2003',N'Đồng Nai')
go
select * from UserTable
go
exec SelectUserCountry @city = N'Long An'
go

CREATE PROCEDURE Login (@email varchar(30),@password varchar(30))
As 
Select case 
    when exists (Select * from UserTable where email = @email and pwd = @password)    
    then  'true'
    else    'false'
    End as 'Result'
GO