create login inventoryControlUser with password = 'qwe#$rR123'
create user inventoryControlUser for login inventoryControlUser
create database InventoryControl
use InventoryControl
Grant select,insert,update,delete to inventoryControlUser
create table Item (
			itemId int primary key identity not null,
			[codItem] varchar(255) not null, 
			[nome] varchar(255) not null, 
			quantidade int not null,
			ultimoLancamento Date not null
		)

		

