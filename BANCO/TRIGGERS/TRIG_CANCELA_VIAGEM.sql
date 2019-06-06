GO
CREATE TRIGGER CANCELA_VIAGEM
ON VIAGEM
INSTEAD OF DELETE
AS
	BEGIN
		DECLARE
		@CODVIAGEM INT
		SELECT @CODVIAGEM = ID FROM DELETED
		DELETE FROM FROTA WHERE CODVIAGEM = @CODVIAGEM
		DELETE FROM VIAGEM WHERE ID = @CODVIAGEM
	END
GO