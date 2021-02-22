USE AdminPanel;

--INSERT IN PRODUCT TYPES TABLE
INSERT INTO ProductTypes(NAME_TYPE)
					VALUES('PRODUCT');

--INSERT IN PRODUCTS TABLE 
INSERT INTO Products (NAME_PRODUCT, ID_TYPE_FOREIGN)
					VALUES('POTATO', 2);

--INSERT IN PRDOUCT PROPERTYS 
INSERT INTO ProductPropertys(PROPERTYS)
					VALUES('{\"ProductName\":\"Potato\"}');

--INSERT IN PRODUCT PROPERTY BINDINGS TABLE
INSERT INTO ProductPropertyBindings(ID_PRODUCT_FOREIGN, ID_PROPERTY_FOREIGN)
					VALUES(7, 3);

--SELECT PRODUCT 
SELECT 
	PROD.NAME_PRODUCT AS '�������� ��������',
	PT.NAME_TYPE AS '��� ��������',
	PP.PROPERTYS AS '������ ����������'
FROM Products AS PROD
LEFT JOIN ProductPropertyBindings PPB ON PROD.ID_PRODUCT_PRIMARY = PPB.ID_PRODUCT_FOREIGN
LEFT JOIN ProductPropertys PP ON PP.ID_PROPERY_PRIMARY = PPB.ID_PROPERTY_FOREIGN
LEFT JOIN ProductTypes PT ON PT.ID_TYPE_PRIMARY = PROD.ID_TYPE_FOREIGN
WHERE PROD.ID_PRODUCT_PRIMARY LIKE '6';