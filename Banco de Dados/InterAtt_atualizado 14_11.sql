create database telalogin;
use telalogin;

create table novo_usuario(
id int auto_increment,
nm_User varchar(20) not null,
senha_User varchar(50) not null,
email_User varchar (256) not null,
constraint pk_novo_usuario primary key(id),
constraint usuario unique (email_User),
constraint usuario_u unique (nm_User)
);

create table nv_Pedido(
id_Pedido int auto_increment,
num_pedido varchar (20) not null,
vl_Total decimal not null,
for_Pagamento numeric not null,
constraint pk_nv_Pedido primary key(id_Pedido)
);

create table pedido_Item(
id_Pedidoitem int auto_increment,
cd_Produto numeric (9) not null, 
vl_Produto decimal(7,2) not null,
Qtde_Produto numeric(10), 
id_Pedido int,
constraint pk_pedido_Item primary key(id_Pedidoitem),
constraint fk_nv_Pedido foreign key (id_Pedido)
references nv_Pedido(id_Pedido)
);
create table  Produto(
id_Produto int auto_increment,
cd_Produto numeric (9),
nm_Produto varchar(30),
id_Pedidoitem int,
constraint pk_Produto primary key(id),
constraint fk_Pedidoitem foreign key (id_Pedido_item)
references pedido_Item (id_Pedidoitem)
);

