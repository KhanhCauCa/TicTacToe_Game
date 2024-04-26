create database GameCaroAI
go
use GameCaroAI
go

create table Player
(
	PlayerID nvarchar(30) primary key,
	Username nvarchar(50) not null,
	Password nvarchar(100) not null,
	LastLogin datetime,
	CreateAt datetime default getdate(),
	UpdateAt datetime,
)
go

create table Game
(
	GameID nvarchar(50) primary key,
	PlayerID nvarchar(30),
	Score int,
	Result nvarchar(30),
	GameStatus int,
	CreateAt datetime default getdate(),
	UpdateAt datetime,

	constraint FK_Game_PlayerID foreign key(PlayerID) references Player(PlayerID)
)
go

create or alter procedure CheckLogin
(	
	@Username nvarchar(50),
	@Password nvarchar(100)
)
as
begin
	select * from Player	
	where Username = @Username and Password = @Password
end
go

create or alter trigger UpdatePlayer on Player
after update 
as
begin
    set nocount on
    update Player
    set UpdateAt = getdate()
    where PlayerID IN (select distinct PlayerID from inserted)
end
go

select count(PlayerID) as WinCount
from Game
where PlayerID = N'TK001' and Result = N'Win'
