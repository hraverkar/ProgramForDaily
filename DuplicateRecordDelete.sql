
Delete duplicate row using mssql

Note ---- Quick and Dirty to delete exact duplicated rows (for small tables):

Query ---> 

select  distinct * into t2 from t1;
delete from t1;
insert into t1 select *  from t2;
drop table t2;


here t1 is your table Name where you enter your original Table Name;

