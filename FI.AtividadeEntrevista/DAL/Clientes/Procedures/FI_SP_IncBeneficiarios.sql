﻿CREATE PROC FI_SP_IncBeneficiarios
    @NOME          VARCHAR (50) ,
	@IdCLiente	BIGINT,
    @CPF           VARCHAR (14)
AS
BEGIN
	INSERT INTO BENEFICIARIOS (NOME, IdCliente, CPF) 
	VALUES (@NOME, @IdCliente,@CPF)

	SELECT SCOPE_IDENTITY()
END