INSERT INTO [dbo].[Users] 
	([Id], [UserName], [KnownAs], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) 
VALUES 
	(NEWID(), 'Sri Varu', 'SriVaru', getdate(), 'Admin', getdate(), 'Admin')

INSERT INTO [dbo].[Users] 
	([Id], [UserName], [KnownAs], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) 
VALUES 
	(NEWID(), 'Bob', 'Bob', getdate(), 'Admin', getdate(), 'Admin')

INSERT INTO [dbo].[Users] 
	([Id], [UserName], [KnownAs], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) 
VALUES 
	(NEWID(), 'Jane', 'Jane', getdate(), 'Admin', getdate(), 'Admin')

INSERT INTO [dbo].[Users] 
	([Id], [UserName], [KnownAs], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) 
VALUES 
	(NEWID(), 'Tom', 'Tom', getdate(), 'Admin', getdate(), 'Admin')
