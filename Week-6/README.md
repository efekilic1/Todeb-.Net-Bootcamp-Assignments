### odev-6
# Son Teslim Tarihi: 05/08/2022 23:00


### Swagger UI

<img width="1277" alt="Ekran Resmi 2022-08-03 18 28 32" src="https://user-images.githubusercontent.com/105243448/182647711-ab1502ee-47ec-4bdb-85cf-b881d17fe365.png">
<img width="1264" alt="Ekran Resmi 2022-08-03 18 04 27" src="https://user-images.githubusercontent.com/105243448/182643474-ab703d6c-9e9d-4354-a84e-404f653a5e27.png">

### Database


<img width="277" alt="Ekran Resmi 2022-08-03 18 25 18" src="https://user-images.githubusercontent.com/105243448/182646984-77adf1e3-a4bc-46b9-bbf9-f419c488d378.png">



### 1.  Register User (Post Methodu ve Çıktısı) 

Bu method ile kullanıcı oluşturabiliyoruz. 

<img width="1252" alt="Ekran Resmi 2022-08-03 17 38 46" src="https://user-images.githubusercontent.com/105243448/182638912-4e910710-3418-4f27-8445-70e81d2cc1de.png">
<img width="1227" alt="Ekran Resmi 2022-08-03 17 39 01" src="https://user-images.githubusercontent.com/105243448/182638935-e00f43c7-e338-430c-a40f-4f9f34891147.png">


### 2.  Login User (Post Methodu ve Çıktısı)  

Bu method ile oluşturduğumuz kullanıcıya giriş yapabiliyor ve token alabiliyoruz. 

<img width="1251" alt="Ekran Resmi 2022-08-03 17 40 32" src="https://user-images.githubusercontent.com/105243448/182639091-c1c5cf55-e48b-43f4-8fbd-44f89a768698.png">
<img width="1231" alt="Ekran Resmi 2022-08-03 17 40 56" src="https://user-images.githubusercontent.com/105243448/182639100-368ef2f2-ef95-47f7-b6b0-2ef7163e1e39.png">


### 3.  JWT Token ve Encoding

Aldığımız tokenın çözümlenmiş hali.

![Ekran Resmi 2022-08-03 17 43 19](https://user-images.githubusercontent.com/105243448/182639305-23570f46-80b1-4471-bac0-15f4c145c549.png)


### 4. Get Customer Methodu Çıktısı, JWT Token ile

CustomerController sınıfını [Authorize] attribute'u ile korumaya aldık ve yetkisiz erişimleri engelledik.
 
<img width="492" alt="Ekran Resmi 2022-08-03 18 30 31" src="https://user-images.githubusercontent.com/105243448/182648186-890ae803-dcf7-4794-b401-6cada927df03.png">

<img width="1229" alt="Ekran Resmi 2022-08-03 17 44 42" src="https://user-images.githubusercontent.com/105243448/182639604-c2b41015-d123-4d20-9552-dcbb82adcb31.png">


### 5. Login User, Postman ile 

<img width="840" alt="Ekran Resmi 2022-08-03 16 44 23" src="https://user-images.githubusercontent.com/105243448/182639937-447e97ab-2fe5-4508-84ef-62a26be6683a.png">


### 5. Get Customer JWT Token, Postman ile 

<img width="847" alt="Ekran Resmi 2022-08-03 16 47 35" src="https://user-images.githubusercontent.com/105243448/182640135-dfb287a3-b599-48f7-9612-63bbfd781215.png">

### 6. Get Customer JWT Token olmadan, Postman ile 401 Unauthorized


<img width="849" alt="Ekran Resmi 2022-08-03 16 45 57" src="https://user-images.githubusercontent.com/105243448/182640516-2e8d6ae5-abd6-43bf-9245-600ebf027771.png">


### 7. Get  Customer Methodu Çıktısı, JWT Token olmadan, Swagger 401 Unauthorized

<img width="1269" alt="Ekran Resmi 2022-08-03 16 58 59" src="https://user-images.githubusercontent.com/105243448/182640746-c2476259-82f7-4244-baa5-cd58b6a54375.png">


### 8. Fluent Validation User Register Password ve Confirm Password uyum kontrolü

<img width="1255" alt="Ekran Resmi 2022-08-03 17 29 44" src="https://user-images.githubusercontent.com/105243448/182641029-287f4c24-af81-4d1b-9eab-f985c10d5fc5.png">
<img width="1221" alt="Ekran Resmi 2022-08-03 17 30 06" src="https://user-images.githubusercontent.com/105243448/182641066-026b564e-512e-42cc-af24-e51d39faf394.png">


### Database Users Tablosu


<img width="844" alt="Ekran Resmi 2022-08-03 18 06 34" src="https://user-images.githubusercontent.com/105243448/182647115-4779918d-36d5-48ec-ac77-c53c4782f127.png">


