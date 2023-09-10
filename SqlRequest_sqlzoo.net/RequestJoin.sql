--Написать запрос на то, сколько голоd забила каждая страна
SELECT teamname, COUNT(matchid) as count_goal
FROM goal JOIN eteam ON (goal.teamid=eteam.id)
GROUP BY teamname

--Посчитать лучшего бомбардира чемпионата. (человек, который забил больше всего голов)
SELECT TOP 1 player, COUNT(*) AS total_goals, SUM(gtime) AS total_time
FROM goal
GROUP BY player
ORDER BY total_goals DESC, total_time
--Поставил доп сортировку, так как у нескольких футболистов одинаковое количество голов