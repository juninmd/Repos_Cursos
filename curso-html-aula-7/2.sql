SELECT * FROM SOR_T_SORVETE FOR UPDATE

SELECT * FROM SOR_t_SORVETE WHERE PRECO > 10

SELECT * FROM SOR_t_SORVETE WHERE preco = (select max(preco) from sor_t_sorvete )

select nome from sor_t_sorvete where descricao like '%melhor%'

select sum(preco) PrecoTOTAL from sor_t_sorvete
