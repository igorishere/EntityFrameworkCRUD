/*
   quarta-feira, 2 de dezembro de 202021:19:03
   User: sa
   Server: IGOR-PC
   Database: EFCRUD
   Application: 
*/

/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
use [EFCRUD]
go

BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Pessoas
	(
	PessoasID int NOT NULL IDENTITY (1, 1),
	PrimeiroNome varchar(50) NULL,
	UltimoNome varchar(50) NULL,
	Cidade varchar(50) NULL,
	Endereco varchar(250) NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Pessoas ADD CONSTRAINT
	PK_Pessoas PRIMARY KEY CLUSTERED 
	(
	PessoasID
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Pessoas SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
