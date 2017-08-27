SELECT weather.id AS 'Id'
FROM weather
JOIN weather w 
ON DATEDIFF(day, weather.date, w.date) = 1
AND weather.Temperature < w.Temperature
;