CREATE PROCEDURE [dbo].[AddOrEdit]
	@mode nvarchar (10),
	@champ_id int,
	@champ_nom nvarchar (50),
	@champ_mdp nvarchar (100)

AS
	if @mode ='Add'
	BEGIN
	INSERT INTO AdminTB
	(
	champ_nom,
	champ_mdp
	)
	VALUES
	(
	@champ_nom,
	@champ_mdp
	)
	END
