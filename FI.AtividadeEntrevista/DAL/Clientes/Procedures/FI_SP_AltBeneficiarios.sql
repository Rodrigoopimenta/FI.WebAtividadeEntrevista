CREATE PROC FI_SP_AltBeneficiarios
    @NOME          VARCHAR (50) ,
	@IdCliente		BIGINT,
	@CPF		   VARCHAR(14),
	@Id           BIGINT
AS
BEGIN
	UPDATE BENEFICIARIOS 
	SET 
		NOME = @NOME, 
		IdCliente = @IdCliente,
		CPF = @CPF
	WHERE Id = @Id
END