﻿CREATE PROC FI_SP_DelBeneficiarios
	@ID BIGINT
AS
BEGIN
	DELETE BENEFICIARIOS WHERE ID = @ID
END