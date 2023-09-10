
--Выбрать континенты с суммарной площадью стран большей 1000000
SELECT continent, SUM(area) as sum_area
FROM world
GROUP BY continent
HAVING SUM(area) > 10000000 -- Или HAVING sum_area > 10000000(На тестовом сайте почему-то не сработало)

--Выбрать страны, у которых gdp меньше 10000000 и больше 10000
SELECT name, gdp
FROM world
WHERE  gdp > 10000 AND gdp < 100000000

--Посчитать кол-во стран, у которых ввп больше площади большее чем в 10 раз
SELECT COUNT(name) as сount_сountry
FROM world
WHERE gdp > area*1