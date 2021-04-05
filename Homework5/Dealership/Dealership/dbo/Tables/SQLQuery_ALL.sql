--A)You need to have a way of grouping all your Inventory cars by Brand. 
SELECT B.BRAND_NAME, COUNT(C.CAR_ID) AS 'BRAND_NUMBERS'
FROM CARS C INNER JOIN MODELS M 
ON C.MODEL_ID=M.MODEL_ID
INNER JOIN BRANDS B
ON M.BRAND_ID=B.BRAND_ID
GROUP BY B.BRAND_NAME


--B)Given a car Model, you need to be able to display all the 
--ActualCarFeatures for all the cars that are currently in your Inventory.
SELECT *
FROM MODELS M INNER JOIN CARS C
ON M.MODEL_ID=C.MODEL_ID
INNER JOIN ACTUAL_FEATURES AF
ON C.ACTUAL_FEATURE_ID=AF.ACTUAL_FEATURE_ID
--WHERE UPPER(M.MODEL_NAME)='DUSTER'


--C)Given a car Model, you need to be able to 
--display all its Possible Car Features. 
SELECT M.MODEL_NAME, C.CAR_ID, PF.*
FROM MODELS M INNER JOIN CARS C
ON M.MODEL_ID=C.MODEL_ID
RIGHT JOIN POSSIBLE_FEATURES PF
ON C.POSSIBLE_FEATURE_ID=PF.POSSIBLE_FEATURE_ID
WHERE UPPER(M.MODEL_NAME)='DUSTER' 
OR (PF.POSSIBLE_FEATURE_ID LIKE '[1]%' AND NOT PF.POSSIBLE_FEATURE_ID=101)


--D)You need to know all the customers who 
--bought cars to in the past month, in order to check for their feedback. 
SELECT *
FROM CUSTOMERS C
WHERE DATE_BOUGHT_VEHICLE
BETWEEN DATEFROMPARTS(2021,03,01) AND DATEFROMPARTS(2021,03,31)


--E)You need to know all the customers who expressed interest 
--in a car the past month but did not end up buying it, 
--in order to be able to contact them and persuade them to buy it. 
SELECT *
FROM CUSTOMERS
WHERE DATE_BOUGHT_VEHICLE IS NULL
AND DATE_VIEWED_CAR BETWEEN DATEFROMPARTS(2021,03,01) AND DATEFROMPARTS(2021,03,31)


--F)Given a certain fabrication year, you need to 
--display all the cars in your inventory that were produced that year.
SELECT *
FROM CARS C
WHERE YEAR(C.DATE_MANUFACTURED)=2020


--G)Given a certain price range, you need to be able to 
--present the range of Models to your potential customers. 
SELECT M.MODEL_NAME, AF.ACTUAL_PRICE
FROM MODELS M INNER JOIN CARS C
ON M.MODEL_ID=C.MODEL_ID
INNER JOIN ACTUAL_FEATURES AF
ON C.ACTUAL_FEATURE_ID=af.ACTUAL_FEATURE_ID
WHERE AF.ACTUAL_PRICE BETWEEN 25000 AND 30000


--H)Given a certain feature (Diesel vs Gas vs Electric/ Manual vs Automatic etc),
--you need to be able to present a range of cars in your Inventory to your 
--potential customers for a test drive.
SELECT M.MODEL_NAME, C.*, AF.*
FROM MODELS M INNER JOIN CARS C
ON M.MODEL_ID=C.MODEL_ID
INNER JOIN ACTUAL_FEATURES AF
ON C.ACTUAL_FEATURE_ID=AF.ACTUAL_FEATURE_ID
WHERE UPPER(AF.TRANSMISSION)='AUTOMATIC'
--AND UPPER(AF.FUEL)='ELECTRIC'