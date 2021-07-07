use SistemaFacturacionMVC;

--productos sin parametros de busqueda
create procedure ventaProductos
as
select 
	p.idProduct,
	p.name, 
	ip.price,
	ip.quantity,
    sum(ip.price * quantity) as Total_Vendido, 
    i.dateInvoice
from 
	product as p, 
	invoiceProduct ip, 
	invoice i
where p.idProduct = ip.idProduct and ip.idInvoice = i.id
group by p.idProduct, p.name, i.dateInvoice, ip.price, ip.quantity

execute ventaProductos
--productos por id 
create procedure VentasxProductoxID @idProduct int
as
select p.idProduct, p.name, sum(ip.price * quantity) as Total_Vendido, i.dateInvoice
from product p, invoiceProduct ip, invoice i where p.idProduct = ip.idProduct and ip.idInvoice = i.id
and p.idProduct = @idProduct
group by p.idProduct, p.name, i.dateInvoice

--productos por todos los parametros de busqueda

create procedure VentasxProducto @fechaInicio date, @fechaFinal date, @idProduct int
as
select p.idProduct, p.name, sum(ip.price * quantity) as Total_Vendido, i.dateInvoice
from product p, invoiceProduct ip, invoice i where p.idProduct = ip.idProduct and ip.idInvoice = i.id
and dateInvoice between @fechaInicio and @fechaFinal
and p.idProduct = @idProduct
group by p.idProduct, p.name, i.dateInvoice

--productos por fechas
create procedure VentasxProductoxfechas @fechaInicio date, @fechaFinal date
as
select p.idProduct, p.name, sum(ip.price * quantity) as Total_Vendido, i.dateInvoice
from product p, invoiceProduct ip, invoice i where p.idProduct = ip.idProduct and ip.idInvoice = i.id
and dateInvoice between @fechaInicio and @fechaFinal
group by p.idProduct, p.name, i.dateInvoice


--estadisticas facturas por fechas
create proc estadisticasFactura @fechaInicio date, @fechaFinal date 
as 
select COUNT(*) as Total_facturas, SUM(i.total) as monto_facturado, sum(ip.quantity) as total_Productos, i.dateInvoice
from invoice i, invoiceProduct ip where i.id = ip.idInvoice
and i.dateInvoice between @fechaInicio and @fechaFinal
group by i.dateInvoice


--compras clientes sin parametros 
create proc ventasClientes 
as 
select c.id, c.name, c.lastname, sum(i.total) as total_vendido, i.dateInvoice
from invoice i, client c where i.idClient = c.id
group by c.id, c.name, c.lastname, i.dateInvoice

--compras clientes por id
create proc ventasClientesID @id int  
as 
select c.id, c.name, c.lastname, sum(i.total) as total_vendido, i.dateInvoice
from invoice i, client c where i.idClient = c.id
and c.id = @id
group by c.id, c.name, c.lastname, i.dateInvoice

--compras clientes por id y fechas 

create proc ventasClientesIDFecha @id int, @fechaInicio date, @fechaFin date  
as 
select c.id, c.name, c.lastname, sum(i.total) as total_vendido, i.dateInvoice
from invoice i, client c where i.idClient = c.id
and c.id = @id
and i.dateInvoice between @fechaInicio and @fechaFin
group by c.id, c.name, c.lastname, i.dateInvoice

--compras clientes por fechas

create proc ventasClientesFecha @fechaInicio date, @fechaFin date  
as 
select c.id, c.name, c.lastname, sum(i.total) as total_vendido, i.dateInvoice
from invoice i, client c where i.idClient = c.id
and i.dateInvoice between @fechaInicio and @fechaFin
group by c.id, c.name, c.lastname, i.dateInvoice


