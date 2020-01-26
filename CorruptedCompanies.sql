SELECT co.CompanyName, co.CompanyId   FROM Company co
WHERE NOT EXISTS ( SELECT 1 FROM Advertisement ad WHERE ad.CompanyId = co.CompanyId )


CREATE TABLE Page(
    PageId INTeger  PRIMARY KEY AUTOINCREMENT NOT NULL ,
    PageDesc TEXT UNIQUE NOT NULL
);
