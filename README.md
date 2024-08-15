# 20IS3-3-practic
# <h1 align="left">Hi there, I'm <a href="https://daniilshat.ru/" target="_blank">Vika</a> <img src="https://github.com/blackcater/blackcater/raw/main/images/Hi.gif" height="32"/></h1>
## Задание 1, 2

### Создание первого API. Взаимодействие с API
##

#### 1. Добовляем метод с добавлением новой записи
![image](https://github.com/BerezkaVika/20IS3-3-practic/blob/master/screenshots/prac%201_2/1_1.png)

#### 2. Добавили метод с редактированием записи по определенному индексу
![image](https://github.com/BerezkaVika/20IS3-3-practic/blob/master/screenshots/prac%201_2/1_2.png)

#### 3. Добавили метод удаления определенной записи по индексу
![image](https://github.com/BerezkaVika/20IS3-3-practic/blob/master/screenshots/prac%201_2/1_3.png)
#### 4. Метод поиска элемента по индексу
![image](https://github.com/BerezkaVika/20IS3-3-practic/blob/master/screenshots/prac%201_2/1_4.png)
#### 5. Метод подсчета записей c определенной погодой
![image](https://github.com/BerezkaVika/20IS3-3-practic/blob/master/screenshots/prac%201_2/1_5.png)
#### 6. Метод метода получения всех записей, который вернёт отсортированный список.
Работа метода должна быть следующая: <br />
a. Если значение параметра null - верните список таким, какой он есть. <br />
b. Если значение параметра 1 - верните отсортированный список по возрастанию. <br />
c. Если значение параметра -1 - верните отсортированный список по убыванию. <br />
d. При всех остальных значениях вернуть ошибку (BadRequest) сообщением “Некорректное значение параметра sortStrategy” <br /> 
<br />
![image](https://github.com/BerezkaVika/20IS3-3-practic/blob/master/screenshots/prac%201_2/1_6.png)
### Конечный результат первогозадания
#### 7 методов для работы со списком
![image](https://github.com/BerezkaVika/20IS3-3-practic/blob/master/screenshots/prac%201_2/1_7.png)


#### 1. Создаем публичный класс с информацией о погоде
![image](https://github.com/BerezkaVika/20IS3-3-practic/blob/master/screenshots/prac%201_2/2_1.png)

#### 2. Создаем тестовый набор данных с подготовленными записями о погоде для изменения контроллера
![image](https://github.com/BerezkaVika/20IS3-3-practic/blob/master/screenshots/prac%201_2/2_1.png)
#### 3. Переделываем метод из прошлой работы для вывода всех записей
![image](https://github.com/BerezkaVika/20IS3-3-practic/blob/master/screenshots/prac%201_2/2_1.png)
#### 4. Также изменим метод вывода одной записи по индексу
![image](https://github.com/BerezkaVika/20IS3-3-practic/blob/master/screenshots/prac%201_2/2_4.png)
#### 5. Также изменим остальные методов
![image](https://github.com/BerezkaVika/20IS3-3-practic/blob/master/screenshots/prac%201_2/2_5_1.png)
![image](https://github.com/BerezkaVika/20IS3-3-practic/blob/master/screenshots/prac%201_2/2_5_2.png)
![image](https://github.com/BerezkaVika/20IS3-3-practic/blob/master/screenshots/prac%201_2/2_5_3.png)
#### 6. Добавим метод поиски города
![image](https://github.com/BerezkaVika/20IS3-3-practic/blob/master/screenshots/prac%201_2/2_6.png)
#### 7. Проверяем все
![image](https://github.com/BerezkaVika/20IS3-3-practic/blob/master/screenshots/prac%201_2/2_7.png)
## Тестирование метода удаления
![RemoveAt(14)_Error(more_than_count)](https://user-images.githubusercontent.com/125024527/219578500-39f1603d-bf07-4f93-a443-3b43f106d24d.jpg)
##
![RemoveAt(10)_Succes](https://user-images.githubusercontent.com/125024527/219578510-9cb462e4-20e9-44e1-a4fc-c9dcf4aea86f.jpg)
##
## Тестирование метода добавления и обновления
![Update(14, SuperCool)_Error(more_than_count)](https://user-images.githubusercontent.com/125024527/219578516-ef00edb0-271c-4bf4-9c11-0c85665dfc7d.jpg)
##
![Update(10, SuperCool)_Succes](https://user-images.githubusercontent.com/125024527/219578525-ab5c20ce-0a3e-4568-a32d-b8fa101a6305.jpg)
##
![Add](https://user-images.githubusercontent.com/125024527/219578533-c6e19e7b-7380-48b2-a142-031dea6ec9f2.jpg)
##
## Тестирование метода добавления и нахождения данных по индексу
![GetAll(-1)](https://user-images.githubusercontent.com/125024527/219578538-e2642565-d2f1-4593-9ddd-9243e25e1a6b.jpg)
##
![GetAll(1)](https://user-images.githubusercontent.com/125024527/219578543-c5bcfd04-ce83-4c11-86e7-f9d155a473f1.jpg)
##
![GetAll(null)](https://user-images.githubusercontent.com/125024527/219578548-cfc12592-0eae-400e-914e-0b09c61bba00.jpg)
##
![GetByName](https://user-images.githubusercontent.com/125024527/219578561-e6d1e8fe-b454-4d95-a1ec-f8f9079a3e13.jpg)
##
![GetByIndex](https://user-images.githubusercontent.com/125024527/219578571-7a46d397-b9e1-4386-b829-7d6ee7bc15f9.jpg)
##
![MainMenu](https://user-images.githubusercontent.com/125024527/219578583-f8fd1496-18ec-4682-8314-82043feccccb.jpg)



## Задание 3
## Визуализация БД

                   
![image](https://user-images.githubusercontent.com/125024527/222701901-a2cced6b-f26a-430a-a795-022c65937d68.png)

![image](https://user-images.githubusercontent.com/125024527/222717443-6a4272ef-7ae5-4d7a-b6e3-c60a12bb550c.png)

![image](https://user-images.githubusercontent.com/125024527/222720445-1c13706f-2101-4579-bb3a-e6e29a720832.png)





## Задание 4


![1](https://user-images.githubusercontent.com/125024527/224264550-70a406ec-6cfa-4cc8-b159-2f2a9cead76b.png)

![2](https://user-images.githubusercontent.com/125024527/224264613-130e99d8-b3bf-41ba-bf5a-5cc37eafdfe7.png)





## Задание 6
#### Файлы миграции


![image](https://user-images.githubusercontent.com/125024527/230562281-254f99f9-f11c-4d35-9990-f6c917d0d6e9.png)


![image](https://user-images.githubusercontent.com/125024527/230562297-be31a009-2236-400b-bdcd-aceca4b6702d.png)




#### Миграция БД

![image](https://user-images.githubusercontent.com/125024527/230562371-a288458f-eb12-4e4f-b517-b64f5deeb20f.png)


![image](https://user-images.githubusercontent.com/125024527/230562380-0c4d1699-a627-4d9b-9639-b659b825c186.png)




## Задание 7
#### Создание и настройки .EditorConfig


![image](https://github.com/BerezkaVika/20IS3-3-practic/blob/master/screenshots/prac7-1.png)

![image](https://github.com/BerezkaVika/20IS3-3-practic/blob/master/screenshots/prac7-2.png)


![image](https://github.com/BerezkaVika/20IS3-3-practic/blob/master/screenshots/prac7-3.png)

![image](https://github.com/BerezkaVika/20IS3-3-practic/blob/master/screenshots/prac7-4.png)

![image](https://github.com/BerezkaVika/20IS3-3-practic/blob/master/screenshots/prac7-5.png)



####  Знакомство с dotnet-cli. Использование команд.

![image](https://github.com/BerezkaVika/20IS3-3-practic/blob/master/screenshots/prac7-6.png)

![image](https://github.com/BerezkaVika/20IS3-3-practic/blob/master/screenshots/prac7-7.png)

![image](https://github.com/BerezkaVika/20IS3-3-practic/blob/master/screenshots/prac7-8.png)



####  Добавление пакета (библиотеки) в проект

![image](https://github.com/BerezkaVika/20IS3-3-practic/blob/master/screenshots/prac7-9.png)


####  Проверка форматирования кода через командную строку


![image](https://github.com/BerezkaVika/20IS3-3-practic/blob/master/screenshots/prac7-10.png)

![image](https://github.com/BerezkaVika/20IS3-3-practic/blob/master/screenshots/prac7-11.png)


## GitHub Actions

####  Создание .yml файла


![image](https://github.com/BerezkaVika/20IS3-3-practic/blob/master/screenshots/prac7-12.png)


#### Проверка работы GitHub Actions


![image](https://github.com/BerezkaVika/20IS3-3-practic/blob/main/screenshots/prac7_13.png)






## Задание 8



#### Изменение метода AddSwaggerGen в Program.cs

![image](https://github.com/BerezkaVika/20IS3-3-practic/blob/main/screenshots/prac8_1.png)

![image](https://github.com/BerezkaVika/20IS3-3-practic/blob/main/screenshots/prac8_2.png)



#### Изменение метода Add в контроллере UserController

![image](https://github.com/BerezkaVika/20IS3-3-practic/blob/main/screenshots/prac8_3.png)



#### Добавление описания и пояснения к методу добавления пользователя

![image](https://github.com/BerezkaVika/20IS3-3-practic/blob/main/screenshots/prac8_4.png)





## Задание 9



#### Изменение метода AddSwaggerGen в Program.cs

![image](https://github.com/BerezkaVika/20IS3-3-practic/blob/main/screenshots/prac_9/1.png)



#### Добавляем класс UserServiceTest и приводим конструктор класса к следующему виду:

![image](https://github.com/BerezkaVika/20IS3-3-practic/blob/main/screenshots/prac_9/2.png)



#### Подключение пакета Moq к проекту

![image](https://github.com/BerezkaVika/20IS3-3-practic/blob/main/screenshots/prac_9/3.png)




#### Добавление проверки на null

![image](https://github.com/BerezkaVika/20IS3-3-practic/blob/main/screenshots/prac_9/4.png)




#### Прохождение тестов

![image](https://github.com/BerezkaVika/20IS3-3-practic/blob/main/screenshots/prac_9/5.png)





#### Изменение метода Create в UserService и добавление обработки на null с вызовом исключения throw new ArgumentNullException

![image](https://github.com/BerezkaVika/20IS3-3-practic/blob/main/screenshots/prac_9/6.png)




#### Результат прохождения тестов

![image](https://github.com/BerezkaVika/20IS3-3-practic/blob/main/screenshots/prac_9/7.png)




#### Переделываем тестовый метод

![image](https://github.com/BerezkaVika/20IS3-3-practic/blob/main/screenshots/prac_9/8.png)



#### Создаём метод, который будет выдавать комбинации с невалиднымиданными пользователей

![image](https://github.com/BerezkaVika/20IS3-3-practic/blob/main/screenshots/prac_9/9.png)




#### Прохождение тестов

![image](https://github.com/BerezkaVika/20IS3-3-practic/blob/main/screenshots/prac_9/10.png)






#### Метод проверки успешного задания пользователя

![image](https://github.com/BerezkaVika/20IS3-3-practic/blob/main/screenshots/prac_9/12.png)





#### Тестирование через dotnet-cli

![image](https://github.com/BerezkaVika/20IS3-3-practic/blob/main/screenshots/prac_9/11.png)




#### Таким образом, мы обеспечили проверку кода и на самом GitHub-репозитории.

![image](https://github.com/BerezkaVika/20IS3-3-practic/blob/main/screenshots/prac_9/13.png)




![image](https://github.com/BerezkaVika/20IS3-3-practic/blob/main/screenshots/prac8_5.png)

