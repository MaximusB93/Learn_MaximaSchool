-- Написать запрос на удаление дубликатов из таблицы. Имеется таблица с одной колонкой - "Name". Написать запрос , после выполнения которого удалятся дубликаты в таблице.
-- "Adam"
-- "Adam"
-- "Eva"
-- "Eva"
-- "Eva"
--  
-- 
-- После выполнения - 
-- "Adam"
-- "Eva"




  
--Добавляем в таблицу второй столбец с уникальным ID
ALTER TABLE "TableName"
ADD COLUMN Id SERIAL PRIMARY KEY;

--Делаем удаление
DELETE FROM "TableName" WHERE "id" NOT IN (SELECT MIN("id") FROM "TableName" GROUP BY "FirstName" );

--Удаляем столбец id, если нужно
ALTER TABLE  "TableName"
DROP COLUMN "id"