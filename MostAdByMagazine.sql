SELECT
	ma.MagazineName,
	COUNT(*) AdCount
FROM
	Advertisement ad
JOIN MagazineDate md ON
	ad.MagazineDateId = md.MagazineDateId
JOIN Magazine ma ON
	md.MagazineId = ma.MagazineId
GROUP BY
	ma.MagazineId
ORDER by
	AdCount desc;