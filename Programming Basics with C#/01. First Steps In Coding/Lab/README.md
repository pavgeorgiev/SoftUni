# Първи стъпки в програмирането

Задачи за упражнение в клас и за домашно към курса ["Основи на програмирането" @ СофтУни](https://softuni.bg/courses/programming-basics).

Тествайте решенията си в **judge системата**: [https://judge.softuni.org/Contests/2339/First-Steps-In-Coding-Lab](https://judge.softuni.org/Contests/2339/First-Steps-In-Coding-Lab)

## 01\. Конзолна програма "Hello SoftUni"

Напишете **конзолна C# програма**, която отпечатва текста "**Hello
SoftUni**".

### Насоки

1.  Стартирайте **Visual Studio**

2.  Създайте нов проект: **Create a new project**

<img src="./media/image1.png" style="width:5.35417in;height:3.06944in" />

3.  Изберете: **Console App (.NET Core)**

<img src="./media/image2.png" style="width:5.04722in;height:2.87428in" />

4.  Въведете **подходящо име** на проекта и **директория**, в която да
    се създаде.

<img src="./media/image3.png" style="width:4.65278in;height:3.09559in" />

<img src="./media/image4.png" style="width:4.57639in;height:2.89178in" />

5.  Намерете секцията **Main(string\[\] args)**. В нея се пише програмен
    код (команди) на езика C#.

6.  Придвижете курсора между отварящата и затварящата скоба **{ }**.

7.  Натиснете **Enter** след отварящата скоба **{**.

<img src="./media/image5.png"
style="width:6.65792in;height:1.81011in" />

8.  Напишете следния програмен код (команда за печатане на текста
    **"Hello SoftUni"**):

| Console.WriteLine("Hello SoftUni"); |
| ----------------------------------- |

Кодът на програмата се пише отместен навътре с една табулация спрямо
отварящата скоба **{**.

<img src="./media/image6.png" style="width:7.24653in;height:1.98125in" />

9.  **Стартирайте** програмата с натискане на **Ctrl+F5**. Трябва да
    получите следния резултат:

<img src="./media/image7.png" style="width:3.97917in;height:1.21875in" />

10. **Тествайте** решението на тази задача в онлайн judge системата на
    СофтУни. За целта първо отворете
    <https://judge.softuni.org/Contests/Compete/Index/2339#0>. Влезте с
    вашето потребителско име в СофтУни. Ще се появи прозорец за
    изпращане на решения за задача "**Hello SoftUni**". Копирайте сорс
    кода от Visual Studio и го поставете в полето за изпращане на
    решения:

<img src="./media/image8.png" style="width:5.82231in;height:3.63009in" />

11. **Изпратете решението** за оценяване с бутона **Submit**. Ще
    получите резултата след няколко секунди в таблицата с изпратени
    решения в judge системата:

<img src="./media/image9.png" style="width:6.33226in;height:1.58018in" />

## 02\. Числата от 1 до 10

Напишете C# конзолна програма, която **отпечатва числата от 1 до 10** на
отделни редове на конзолата.

### Насоки

1.  Създайте конзолно C# приложение с име "**Nums1To10**".

2.  Напишете 10 команди **Console.WriteLine()**, една след друга, за да
    отпечатате числата от 1 до 10.

<img src="./media/image10.png" style="width:2.74033in;height:2.7223in" />

3.  **Тествайте** вашето решение на задачата в [Judge](https://judge.softuni.org/Contests/Compete/Index/2339#1)
    системата.

## 03\. Пресмятане на лице на правоъгълник

Да се напише **конзолна програма**, която **въвежда две цели числа (страните на правоъгълника a и b)** и **пресмята лицето на правоъгълник
с тези страни.**

### Примерен вход и изход

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 49%" />
</colgroup>
<thead>
<tr class="header">
<th><strong>вход</strong></th>
<th><strong>изход</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>5</p>
<p>7</p></td>
<td>35</td>
</tr>
</tbody>
</table>

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 49%" />
</colgroup>
<thead>
<tr class="header">
<th><strong>вход</strong></th>
<th><strong>изход</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>6</p>
<p>8</p></td>
<td>48</td>
</tr>
</tbody>
</table>

### Насоки

1.  **Инициализирайте** две променливи (a и b) и в тях запишете
    стойностите въведени от конзолата:

<img src="./media/image11.png" style="width:4.44248in;height:0.79996in" />

2.  **Инициализирайте втора променлива area**, в която да запишете
    стойността за лицето на правоъгълника, получена по формулата **a \*
    b**. Принтирайте получения резултат:

<img src="./media/image12.png" style="width:4.45309in;height:1.61785in" />

## 04\. Конвертор: инчове към сантиметри

Да се напише програма, която **чете от конзолата реално число** и го
преобразува **от инчове в сантиметри**. За целта **умножете инчовете по
2.54** (1 инч = 2.54 сантиметра).

### Примерен вход и изход

| **вход** | **изход** |
| -------- | --------- |
| 5        | 12.7      |

| **вход** | **изход** |
| -------- | --------- |
| 7        | 17.78     |

**Внимание:** в зависимост от регионалните настройки на операционната
система, е възможно вместо **десетична точка** (US настройки) да се
използва **десетична запетая** (BG настройки). Ако програмата очаква
десетична точка и бъде въведено число с десетична запетая или на обратно
(бъде въведена десетична точка, когато се очаква десетична запетая), ще
се получи следната грешка:

<img src="./media/image13.png" style="width:7.24653in;height:1.86528in" />

Препоръчително е **да промените настройките на компютъра си**, така че
да се използва **десетична точка**:

<img src="./media/image14.png" style="width:6.6054in;height:2.04017in" />

<img src="./media/image15.png" style="width:6.12213in;height:3.93436in" />

## 05\. Поздрав по име

Да се напише програма, която **чете от конзолата текст (име на човек)**
и отпечатва "**Hello,** **\<name\>!**", където **\<name\>** е въведеното
име от конзолата.

### Насоки

1.  Създайте променливата **name** от тип **string** и запазете в нея
    името, което получавате от конзолата.

<img src="./media/image16.png" style="width:3.6907in;height:1.63411in" />

2.  Изведете изхода на конзолата като използвате конкатенация (долепяне
    на текстове):

<img src="./media/image17.png" style="width:5.00611in;height:2.31256in" />

3.  Стартирайте програмата с **Ctrl + F5** и тествайте с различни входни
    примери.

<img src="./media/image18.png" style="width:3.75442in;height:1.2139in" />

## 06\. Съединяване на текст и числа

Напишете програма, която прочита от конзолата **име**, **фамилия**,
**възраст** и **град** и печата следното съобщение: "**You are\<firstName\> \<lastName\>, a \<age\>-years old person from \<town\>.**"

### Насоки

1.  Добавете към текущото Visual Studio решение още един **конзолен
    проект**, като изберем с десен бутон върху проекта **Add -\> New
    Project...**

<img src="./media/image19.png" style="width:5.96234in;height:5.34882in" alt="A screenshot of a social media post Description automatically generated" />

2.  Въведете входните данни и ги запишете в променливи с подходящ тип
    данни:  

<img src="./media/image20.png" style="width:4.57165in;height:2.42869in" alt="A screenshot of a cell phone Description automatically generated" />

3.  Изведете на конзолата форматирания изход:  

<img src="./media/image21.png" style="width:5.96591in;height:3.1599in" />

4.  Стартирайте програмата с **Ctrl + F5** и тествайте с различни входни
    примери.

<img src="./media/image22.png" style="width:3.52173in;height:1.05174in" />

**Ако все още получавате резултата от миналата задача, това се получава, защото не сте сменили стартовия проект. Как да се справите с проблема?**

**Както виждате Greeting проекта е с удебелени черни букви – това означава, че това е вашият стартов проект. За да смените стартовия проект, изберете с десен бутон върху желания проект Set as StartUp Project.**

<img src="./media/image23.png" style="width:1.8729in;height:2.75681in" alt="A screenshot of a cell phone Description automatically generated" />

<img src="./media/image24.png" style="width:6.48341in;height:1.475in" />

## 07\. Изготвяне на проекти

Напишете програма, която **изчислява** **колко часа** ще са необходими
на един архитект, за да **изготви проектите** на няколко строителни
обекта. Изготвянето на един проект отнема **три часа**.

**Вход**

От конзолата се четат **2 реда**:

1.  **Името на архитекта - текст**

2.  **Брой на проектите, които трябва да изготви - цяло число в
    интервала \[0 … 100\]**

**Изход**

На конзолата се отпечатва:

- **"The architect {името на архитекта} will need {необходими часове} hours to complete {брой на проектите} project/s."**

**Примерен вход и изход**

<table>
<colgroup>
<col style="width: 11%" />
<col style="width: 32%" />
<col style="width: 2%" />
<col style="width: 11%" />
<col style="width: 41%" />
</colgroup>
<thead>
<tr class="header">
<th><strong>вход</strong></th>
<th><strong>изход</strong></th>
<th rowspan="2"></th>
<th><strong>вход</strong></th>
<th><strong>изход</strong></th>
</tr>
<tr class="odd">
<th><p>George</p>
<p>4</p></th>
<th>The architect George will need 12 hours to complete 4
project/s.</th>
<th><p>Sanya</p>
<p>9</p></th>
<th>The architect Sanya will need 27 hours to complete 9 project/s.</th>
</tr>
</thead>
<tbody>
</tbody>
</table>

## 08\. Зоомагазин

Напишете програма, която **пресмята нужните разходи** за закупуването на храна за кучета и котки. Храната се пазарува от зоомагазин, като една опаковка храна за **кучета е на цена 2.50 лв**, а опаковка храна за **котки струва 4 лв.**

**Вход**

От конзолата се четат **2 реда**:

1.  **Броят на опаковките храна за кучета – цяло число в интервала \[0…100\]**

2.  **Броят на опаковките храна за котки – цяло число в интервала \[0…100\]**

**Изход**

На конзолата се отпечатва:

**"{крайната сума} lv."**

**Примерен вход и изход**

<table style="width:100%;">
<colgroup>
<col style="width: 14%" />
<col style="width: 22%" />
<col style="width: 27%" />
<col style="width: 14%" />
<col style="width: 22%" />
</colgroup>
<thead>
<tr class="header">
<th><strong>вход</strong></th>
<th><strong>изход</strong></th>
<th rowspan="2"></th>
<th><strong>вход</strong></th>
<th><strong>изход</strong></th>
</tr>
<tr class="odd">
<th><p>5</p>
<p>4</p></th>
<th>28.5 lv.</th>
<th><p>13</p>
<p>9</p></th>
<th>68.5 lv.</th>
</tr>
</thead>
<tbody>
</tbody>
</table>

## 09\. Озеленяване на дворове

Божидара разполага с **няколко къщи** на Черноморието и **желае да
озелени дворовете на някои от тях,** като по този начин създаде **уютна
обстановка** **и комфорт на гостите си**. За целта е наела фирма.

Напишете програма, която **изчислява необходимате сума**, които Божидара
ще трябва да заплати на фирмата изпълнител на проекта. Цената на **един
кв. м. е 7.61 лв със ДДС**. Понеже нейният двор е **доста голям**,
фирмата изпълнител предлага **18% отстъпка от крайната цена**.

**Вход**

От конзолата се прочита само **един ред**:

1.  **Кв. метри, които ще бъдат озеленени – реално число в интервала \[0.00 … 10000.00\]**

**Изход**

На конзолата се отпечатват **два реда**:

- **"The final price is: {крайна цена на услугата} lv."**

- **"The discount is: {отстъпка} lv."**

**Примерен вход и изход**

<table>
<colgroup>
<col style="width: 10%" />
<col style="width: 37%" />
<col style="width: 51%" />
</colgroup>
<thead>
<tr class="header">
<th><strong>Вход</strong></th>
<th><strong>Изход</strong></th>
<th><strong>Обяснения</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><strong>550</strong></td>
<td><p>The final price is: 3432.11 lv.</p>
<p>The discount is: 753.39 lv.</p></td>
<td><p>Пресмятаме цената за озеленяване на целия двор:</p>
<p><strong>550</strong> * <strong>7.61</strong> =
<strong>4185.50</strong> лв.</p>
<p>Приспадаме отстъпката (18% = 0.18) от общата сума:</p>
<p><strong>0.18</strong> * <strong>4185.5</strong> =
<strong>753.39</strong> лв.</p>
<p>Калкулираме крайната цена на услугата:</p>
<p><strong>4185.50</strong> – <strong>753.39</strong> 3432.11
лв.</p></td>
</tr>
<tr class="even">
<td><strong>Вход</strong></td>
<td><strong>Изход</strong></td>
<td></td>
</tr>
<tr class="odd">
<td>150</td>
<td><p>The final price is: 936.03 lv.</p>
<p>The discount is: 205.47 lv.</p></td>
<td><p>Пресмятаме цената за озеленяване на целия двор:</p>
<p><strong>150</strong> * <strong>7.61</strong> =
<strong>1141.50</strong> лв.</p>
<p>Приспадаме отстъпката (18% = 0.18) от общата сума:</p>
<p><strong>0.18</strong> * <strong>1141.50</strong> =
<strong>205.47</strong> лв.</p>
<p>Калкулираме крайната цена на услугата:</p>
<p><strong>1141.50</strong> – <strong>205.47</strong> 936.03
лв.</p></td>
</tr>
</tbody>
</table>
