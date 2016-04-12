INSERT INTO Drivers(LastName, FirstName)
	SELECT 'Smith' AS LastName, 'John' AS FirstName
	UNION SELECT 'Jones' AS LastName, 'David' AS FirstName
	UNION SELECT 'Collins' AS LastName, 'Patricia' AS FirstName;
