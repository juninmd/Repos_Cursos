select * from sor_t_usuario
insert into sor_t_usuario values (2,'1@1.com.br','123');
commit;

select * from sor_t_usuario where idusuario = 1 for update;

update sor_t_usuario set email = 'joao@1.com.br' where idusuario = 1;

delete sor_t_usuario where idusuario =2;
