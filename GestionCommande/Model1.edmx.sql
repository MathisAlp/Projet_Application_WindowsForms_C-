
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/13/2022 18:12:46
-- Generated from EDMX file: C:\Users\MATHIS\Desktop\Projet C# L3\GestionCommande\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [db_gestionCmd];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_LivreurLivraison]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Livraison] DROP CONSTRAINT [FK_LivreurLivraison];
GO
IF OBJECT_ID(N'[dbo].[FK_ClientPaiement]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Paiement] DROP CONSTRAINT [FK_ClientPaiement];
GO
IF OBJECT_ID(N'[dbo].[FK_ClientCommande]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Commande] DROP CONSTRAINT [FK_ClientCommande];
GO
IF OBJECT_ID(N'[dbo].[FK_CommandePaiement]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Paiement] DROP CONSTRAINT [FK_CommandePaiement];
GO
IF OBJECT_ID(N'[dbo].[FK_CommandeLivraison]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Commande] DROP CONSTRAINT [FK_CommandeLivraison];
GO
IF OBJECT_ID(N'[dbo].[FK_CommandeDetailsCmd]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetailsCmd] DROP CONSTRAINT [FK_CommandeDetailsCmd];
GO
IF OBJECT_ID(N'[dbo].[FK_ProduitDetailsCmd]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetailsCmd] DROP CONSTRAINT [FK_ProduitDetailsCmd];
GO
IF OBJECT_ID(N'[dbo].[FK_Livreur_inherits_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[User_Livreur] DROP CONSTRAINT [FK_Livreur_inherits_User];
GO
IF OBJECT_ID(N'[dbo].[FK_Client_inherits_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[User_Client] DROP CONSTRAINT [FK_Client_inherits_User];
GO
IF OBJECT_ID(N'[dbo].[FK_Secretaire_inherits_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[User_Secretaire] DROP CONSTRAINT [FK_Secretaire_inherits_User];
GO
IF OBJECT_ID(N'[dbo].[FK_Comptable_inherits_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[User_Comptable] DROP CONSTRAINT [FK_Comptable_inherits_User];
GO
IF OBJECT_ID(N'[dbo].[FK_RespoStock_inherits_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[User_RespoStock] DROP CONSTRAINT [FK_RespoStock_inherits_User];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[DetailsCmd]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DetailsCmd];
GO
IF OBJECT_ID(N'[dbo].[Livraison]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Livraison];
GO
IF OBJECT_ID(N'[dbo].[Commande]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Commande];
GO
IF OBJECT_ID(N'[dbo].[Produit]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Produit];
GO
IF OBJECT_ID(N'[dbo].[Paiement]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Paiement];
GO
IF OBJECT_ID(N'[dbo].[User]', 'U') IS NOT NULL
    DROP TABLE [dbo].[User];
GO
IF OBJECT_ID(N'[dbo].[User_Livreur]', 'U') IS NOT NULL
    DROP TABLE [dbo].[User_Livreur];
GO
IF OBJECT_ID(N'[dbo].[User_Client]', 'U') IS NOT NULL
    DROP TABLE [dbo].[User_Client];
GO
IF OBJECT_ID(N'[dbo].[User_Secretaire]', 'U') IS NOT NULL
    DROP TABLE [dbo].[User_Secretaire];
GO
IF OBJECT_ID(N'[dbo].[User_Comptable]', 'U') IS NOT NULL
    DROP TABLE [dbo].[User_Comptable];
GO
IF OBJECT_ID(N'[dbo].[User_RespoStock]', 'U') IS NOT NULL
    DROP TABLE [dbo].[User_RespoStock];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'DetailsCmd'
CREATE TABLE [dbo].[DetailsCmd] (
    [IdDetailsCmd] int IDENTITY(1,1) NOT NULL,
    [qteCmd] float  NOT NULL,
    [total] float  NOT NULL,
    [CommandeId] int  NOT NULL,
    [ProduitId] int  NOT NULL
);
GO

-- Creating table 'Livraison'
CREATE TABLE [dbo].[Livraison] (
    [IdLivraison] int IDENTITY(1,1) NOT NULL,
    [dateLiv] datetime  NOT NULL,
    [LivreurId] int  NOT NULL
);
GO

-- Creating table 'Commande'
CREATE TABLE [dbo].[Commande] (
    [IdCmd] int IDENTITY(1,1) NOT NULL,
    [dateCmd] datetime  NOT NULL,
    [totalCmd] float  NOT NULL,
    [isPaid] bit  NOT NULL,
    [adresseLiv] nvarchar(max)  NOT NULL,
    [statut] nvarchar(max)  NOT NULL,
    [ClientId] int  NOT NULL,
    [LivraisonId] int  NULL
);
GO

-- Creating table 'Produit'
CREATE TABLE [dbo].[Produit] (
    [IdProduit] int IDENTITY(1,1) NOT NULL,
    [libelle] nvarchar(max)  NOT NULL,
    [qteStock] float  NOT NULL,
    [prixUnitaire] float  NOT NULL,
    [img] varbinary(max)  NOT NULL,
    [description] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Paiement'
CREATE TABLE [dbo].[Paiement] (
    [IdPaiement] int IDENTITY(1,1) NOT NULL,
    [datePaid] datetime  NOT NULL,
    [montant] float  NOT NULL,
    [ClientId] int  NOT NULL,
    [Commande_IdCmd] int  NOT NULL
);
GO

-- Creating table 'User'
CREATE TABLE [dbo].[User] (
    [IdUser] int IDENTITY(1,1) NOT NULL,
    [nom] nvarchar(max)  NOT NULL,
    [prenom] nvarchar(max)  NOT NULL,
    [login] nvarchar(max)  NOT NULL,
    [password] nvarchar(max)  NOT NULL,
    [role] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'User_Livreur'
CREATE TABLE [dbo].[User_Livreur] (
    [IdUser] int  NOT NULL
);
GO

-- Creating table 'User_Client'
CREATE TABLE [dbo].[User_Client] (
    [telephone] int  NOT NULL,
    [adresse] nvarchar(max)  NOT NULL,
    [refCpte] nvarchar(max)  NOT NULL,
    [soldeCpte] float  NOT NULL,
    [IdUser] int  NOT NULL
);
GO

-- Creating table 'User_Secretaire'
CREATE TABLE [dbo].[User_Secretaire] (
    [IdUser] int  NOT NULL
);
GO

-- Creating table 'User_Comptable'
CREATE TABLE [dbo].[User_Comptable] (
    [IdUser] int  NOT NULL
);
GO

-- Creating table 'User_RespoStock'
CREATE TABLE [dbo].[User_RespoStock] (
    [IdUser] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdDetailsCmd] in table 'DetailsCmd'
ALTER TABLE [dbo].[DetailsCmd]
ADD CONSTRAINT [PK_DetailsCmd]
    PRIMARY KEY CLUSTERED ([IdDetailsCmd] ASC);
GO

-- Creating primary key on [IdLivraison] in table 'Livraison'
ALTER TABLE [dbo].[Livraison]
ADD CONSTRAINT [PK_Livraison]
    PRIMARY KEY CLUSTERED ([IdLivraison] ASC);
GO

-- Creating primary key on [IdCmd] in table 'Commande'
ALTER TABLE [dbo].[Commande]
ADD CONSTRAINT [PK_Commande]
    PRIMARY KEY CLUSTERED ([IdCmd] ASC);
GO

-- Creating primary key on [IdProduit] in table 'Produit'
ALTER TABLE [dbo].[Produit]
ADD CONSTRAINT [PK_Produit]
    PRIMARY KEY CLUSTERED ([IdProduit] ASC);
GO

-- Creating primary key on [IdPaiement] in table 'Paiement'
ALTER TABLE [dbo].[Paiement]
ADD CONSTRAINT [PK_Paiement]
    PRIMARY KEY CLUSTERED ([IdPaiement] ASC);
GO

-- Creating primary key on [IdUser] in table 'User'
ALTER TABLE [dbo].[User]
ADD CONSTRAINT [PK_User]
    PRIMARY KEY CLUSTERED ([IdUser] ASC);
GO

-- Creating primary key on [IdUser] in table 'User_Livreur'
ALTER TABLE [dbo].[User_Livreur]
ADD CONSTRAINT [PK_User_Livreur]
    PRIMARY KEY CLUSTERED ([IdUser] ASC);
GO

-- Creating primary key on [IdUser] in table 'User_Client'
ALTER TABLE [dbo].[User_Client]
ADD CONSTRAINT [PK_User_Client]
    PRIMARY KEY CLUSTERED ([IdUser] ASC);
GO

-- Creating primary key on [IdUser] in table 'User_Secretaire'
ALTER TABLE [dbo].[User_Secretaire]
ADD CONSTRAINT [PK_User_Secretaire]
    PRIMARY KEY CLUSTERED ([IdUser] ASC);
GO

-- Creating primary key on [IdUser] in table 'User_Comptable'
ALTER TABLE [dbo].[User_Comptable]
ADD CONSTRAINT [PK_User_Comptable]
    PRIMARY KEY CLUSTERED ([IdUser] ASC);
GO

-- Creating primary key on [IdUser] in table 'User_RespoStock'
ALTER TABLE [dbo].[User_RespoStock]
ADD CONSTRAINT [PK_User_RespoStock]
    PRIMARY KEY CLUSTERED ([IdUser] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [LivreurId] in table 'Livraison'
ALTER TABLE [dbo].[Livraison]
ADD CONSTRAINT [FK_LivreurLivraison]
    FOREIGN KEY ([LivreurId])
    REFERENCES [dbo].[User_Livreur]
        ([IdUser])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LivreurLivraison'
CREATE INDEX [IX_FK_LivreurLivraison]
ON [dbo].[Livraison]
    ([LivreurId]);
GO

-- Creating foreign key on [ClientId] in table 'Paiement'
ALTER TABLE [dbo].[Paiement]
ADD CONSTRAINT [FK_ClientPaiement]
    FOREIGN KEY ([ClientId])
    REFERENCES [dbo].[User_Client]
        ([IdUser])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientPaiement'
CREATE INDEX [IX_FK_ClientPaiement]
ON [dbo].[Paiement]
    ([ClientId]);
GO

-- Creating foreign key on [ClientId] in table 'Commande'
ALTER TABLE [dbo].[Commande]
ADD CONSTRAINT [FK_ClientCommande]
    FOREIGN KEY ([ClientId])
    REFERENCES [dbo].[User_Client]
        ([IdUser])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientCommande'
CREATE INDEX [IX_FK_ClientCommande]
ON [dbo].[Commande]
    ([ClientId]);
GO

-- Creating foreign key on [Commande_IdCmd] in table 'Paiement'
ALTER TABLE [dbo].[Paiement]
ADD CONSTRAINT [FK_CommandePaiement]
    FOREIGN KEY ([Commande_IdCmd])
    REFERENCES [dbo].[Commande]
        ([IdCmd])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CommandePaiement'
CREATE INDEX [IX_FK_CommandePaiement]
ON [dbo].[Paiement]
    ([Commande_IdCmd]);
GO

-- Creating foreign key on [LivraisonId] in table 'Commande'
ALTER TABLE [dbo].[Commande]
ADD CONSTRAINT [FK_CommandeLivraison]
    FOREIGN KEY ([LivraisonId])
    REFERENCES [dbo].[Livraison]
        ([IdLivraison])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CommandeLivraison'
CREATE INDEX [IX_FK_CommandeLivraison]
ON [dbo].[Commande]
    ([LivraisonId]);
GO

-- Creating foreign key on [CommandeId] in table 'DetailsCmd'
ALTER TABLE [dbo].[DetailsCmd]
ADD CONSTRAINT [FK_CommandeDetailsCmd]
    FOREIGN KEY ([CommandeId])
    REFERENCES [dbo].[Commande]
        ([IdCmd])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CommandeDetailsCmd'
CREATE INDEX [IX_FK_CommandeDetailsCmd]
ON [dbo].[DetailsCmd]
    ([CommandeId]);
GO

-- Creating foreign key on [ProduitId] in table 'DetailsCmd'
ALTER TABLE [dbo].[DetailsCmd]
ADD CONSTRAINT [FK_ProduitDetailsCmd]
    FOREIGN KEY ([ProduitId])
    REFERENCES [dbo].[Produit]
        ([IdProduit])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProduitDetailsCmd'
CREATE INDEX [IX_FK_ProduitDetailsCmd]
ON [dbo].[DetailsCmd]
    ([ProduitId]);
GO

-- Creating foreign key on [IdUser] in table 'User_Livreur'
ALTER TABLE [dbo].[User_Livreur]
ADD CONSTRAINT [FK_Livreur_inherits_User]
    FOREIGN KEY ([IdUser])
    REFERENCES [dbo].[User]
        ([IdUser])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdUser] in table 'User_Client'
ALTER TABLE [dbo].[User_Client]
ADD CONSTRAINT [FK_Client_inherits_User]
    FOREIGN KEY ([IdUser])
    REFERENCES [dbo].[User]
        ([IdUser])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdUser] in table 'User_Secretaire'
ALTER TABLE [dbo].[User_Secretaire]
ADD CONSTRAINT [FK_Secretaire_inherits_User]
    FOREIGN KEY ([IdUser])
    REFERENCES [dbo].[User]
        ([IdUser])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdUser] in table 'User_Comptable'
ALTER TABLE [dbo].[User_Comptable]
ADD CONSTRAINT [FK_Comptable_inherits_User]
    FOREIGN KEY ([IdUser])
    REFERENCES [dbo].[User]
        ([IdUser])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdUser] in table 'User_RespoStock'
ALTER TABLE [dbo].[User_RespoStock]
ADD CONSTRAINT [FK_RespoStock_inherits_User]
    FOREIGN KEY ([IdUser])
    REFERENCES [dbo].[User]
        ([IdUser])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------