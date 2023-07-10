# Лаб: Повторения с цикли – While цикъл

Задачи за упражнение и домашно към курса ["Основи на програмирането" в СофтУни](https://softuni.bg/courses/programming-basics).

**Тествайте** решението си в **judge системата**: https://judge.softuni.bg/Contests/2383

## 01\. Четене на думи

Напишете програма, която чете текст от конзолата (стринг) и го принтира,
докато не получи командата "**Stop**".  

**Примерен вход и изход**

<table>
<colgroup>
<col style="width: 14%" />
<col style="width: 31%" />
<col style="width: 6%" />
<col style="width: 14%" />
<col style="width: 32%" />
</colgroup>
<thead>
<tr class="header">
<th><strong>вход</strong></th>
<th><strong>изход</strong></th>
<th></th>
<th><strong>вход</strong></th>
<th><strong>изход</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>Nakov</p>
<p>SoftUni</p>
<p>Sofia</p>
<p>Bulgaria</p>
<p>SomeText</p>
<p>Stop</p>
<p>AfterStop</p>
<p>Europe</p>
<p>HelloWorld</p></td>
<td><p>Nakov</p>
<p>SoftUni</p>
<p>Sofia</p>
<p>Bulgaria</p>
<p>SomeText</p></td>
<td></td>
<td><p>Sofia</p>
<p>Berlin</p>
<p>Moscow<br />
Athens</p>
<p>Madrid</p>
<p>London</p>
<p>Paris</p>
<p>Stop</p>
<p>AfterStop</p></td>
<td><p>Sofia</p>
<p>Berlin</p>
<p>Moscow<br />
Athens</p>
<p>Madrid</p>
<p>London</p>
<p>Paris</p></td>
</tr>
</tbody>
</table>

## 02\. Парола

Напишете програма, която първоначално прочита име и парола на
потребителски профил. След това чете парола за вход.

- при въвеждане на грешна парола: потребителя да се подкани да въведе
  нова парола.

- при въвеждане на правилна парола: отпечатваме "Welcome {username}!".

### Примерен вход и изход

<table>
<colgroup>
<col style="width: 14%" />
<col style="width: 31%" />
<col style="width: 6%" />
<col style="width: 14%" />
<col style="width: 32%" />
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
<th><p>Nakov</p>
<p>1234</p>
<p>pass</p>
<p>1324</p>
<p>1234</p></th>
<th>Welcome Nakov!</th>
<th><p>Gosho</p>
<p>secret</p>
<p>secret</p></th>
<th>Welcome Gosho!</th>
</tr>
</thead>
<tbody>
</tbody>
</table>

### 

## 03\. Сума от числа

Напишете програма, която чете цяло число от конзолата и на всеки следващ
ред цели числа, докато тяхната сума стане по-голяма или равна на
първоначалното число. След приключване да се отпечата **сумата на
въведените числа**.

**Примерен вход и изход**

<table>
<colgroup>
<col style="width: 22%" />
<col style="width: 25%" />
<col style="width: 23%" />
<col style="width: 28%" />
</colgroup>
<thead>
<tr class="header">
<th><strong>вход</strong></th>
<th><strong>изход</strong></th>
<th><strong>вход</strong></th>
<th><strong>изход</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>100</p>
<p>10</p>
<p>20</p>
<p>30</p>
<p>40</p></td>
<td>100</td>
<td><p>20</p>
<p>1</p>
<p>2</p>
<p>3</p>
<p>4</p>
<p>5</p>
<p>6</p></td>
<td>21</td>
</tr>
</tbody>
</table>

## 04\. Редица числа 2k + 1

Напишете програма, която чете число **n**, въведено от потребителя, и
отпечатва **всички числа ≤ n от редицата**: 1, 3, 7, 15, 31, …. Всяко
следващо число се изчислява като умножим **предишното** с **2** и
добавим **1**.

### Примерен вход и изход

<table>
<colgroup>
<col style="width: 10%" />
<col style="width: 11%" />
<col style="width: 4%" />
<col style="width: 10%" />
<col style="width: 11%" />
<col style="width: 4%" />
<col style="width: 10%" />
<col style="width: 11%" />
<col style="width: 4%" />
<col style="width: 10%" />
<col style="width: 12%" />
</colgroup>
<thead>
<tr class="header">
<th><strong>вход</strong></th>
<th><strong>изход</strong></th>
<th rowspan="2"></th>
<th><strong>вход</strong></th>
<th><strong>изход</strong></th>
<th rowspan="2"></th>
<th><strong>вход</strong></th>
<th><strong>изход</strong></th>
<th rowspan="2"></th>
<th><strong>вход</strong></th>
<th><strong>изход</strong></th>
</tr>
<tr class="odd">
<th>3</th>
<th><p>1</p>
<p>3</p></th>
<th>8</th>
<th><p>1</p>
<p>3</p>
<p>7</p></th>
<th>17</th>
<th><p>1</p>
<p>3</p>
<p>7</p>
<p>15</p></th>
<th>31</th>
<th><p>1</p>
<p>3</p>
<p>7</p>
<p>15</p>
<p>31</p></th>
</tr>
</thead>
<tbody>
</tbody>
</table>

## 05\. Баланс по сметка

Напишете програма, която пресмята колко общо пари има в сметката, след
като направите определен брой вноски. На всеки ред ще получавате сумата,
която трябва да внесете в сметката, **до получаване на команда
"NoMoreMoney"** . При всяка получена сума на конзолата трябва да се
извежда **"Increase: "** + сумата и тя да се **прибавя в сметката**. Ако
получите число **по-малко от 0** на конзолата трябва да се изведе
**"Invalid operation!"** и **програмата да приключи**. Когато програмата
приключи трябва да се принтира **"Total: "** + общата сума в сметката
форматирана до втория знак след десетичната запетая.

### Примерен вход и изход

<table>
<colgroup>
<col style="width: 15%" />
<col style="width: 32%" />
<col style="width: 4%" />
<col style="width: 15%" />
<col style="width: 32%" />
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
<th><p>5.51</p>
<p>69.42</p>
<p>100</p>
<p>NoMoreMoney</p></th>
<th><p>Increase: 5.51</p>
<p>Increase: 69.42</p>
<p>Increase: 100.00</p>
<p>Total: 174.93</p></th>
<th><p>120</p>
<p>45.55</p>
<p>-150</p></th>
<th><p>Increase: 120.00</p>
<p>Increase: 45.55</p>
<p>Invalid operation!</p>
<p>Total: 165.55</p></th>
</tr>
</thead>
<tbody>
</tbody>
</table>

## 06\. Най-голямо число

Напишете програма, която до получаване на **командата "Stop",** чете
**цели числа**, въведени от потребителя и намира **най-голямото**
измежду тях. Въвежда се по едно число на ред.

### Примерен вход и изход

<table>
<colgroup>
<col style="width: 8%" />
<col style="width: 8%" />
<col style="width: 3%" />
<col style="width: 8%" />
<col style="width: 8%" />
<col style="width: 3%" />
<col style="width: 8%" />
<col style="width: 8%" />
<col style="width: 3%" />
<col style="width: 8%" />
<col style="width: 8%" />
<col style="width: 3%" />
<col style="width: 8%" />
<col style="width: 8%" />
</colgroup>
<thead>
<tr class="header">
<th><strong>вход</strong></th>
<th><strong>изход</strong></th>
<th rowspan="2"></th>
<th><strong>вход</strong></th>
<th><strong>изход</strong></th>
<th rowspan="2"></th>
<th><strong>вход</strong></th>
<th><strong>изход</strong></th>
<th rowspan="2"></th>
<th><strong>вход</strong></th>
<th><strong>изход</strong></th>
<th rowspan="2"></th>
<th><strong>вход</strong></th>
<th><strong>изход</strong></th>
</tr>
<tr class="odd">
<th><p>100</p>
<p>99</p>
<p>80</p>
<p>70</p>
<p>Stop</p></th>
<th>100</th>
<th><p>-10</p>
<p>20</p>
<p>-30</p>
<p>Stop</p></th>
<th>20</th>
<th><p>45</p>
<p>-20</p>
<p>7</p>
<p>99</p>
<p>Stop</p></th>
<th>99</th>
<th><p>999</p>
<p>Stop</p></th>
<th>999</th>
<th><p>-1</p>
<p>-2</p>
<p>Stop</p></th>
<th>-1</th>
</tr>
</thead>
<tbody>
</tbody>
</table>

## 07\. Най-малко число

Напишете програма, която до получаване на **командата "Stop"**, чете
**цели числа**, въведени от потребителя и намира **най-малкото** измежду
тях. Въвежда се по едно число на ред.

### Примерен вход и изход

<table>
<colgroup>
<col style="width: 8%" />
<col style="width: 8%" />
<col style="width: 3%" />
<col style="width: 8%" />
<col style="width: 8%" />
<col style="width: 3%" />
<col style="width: 8%" />
<col style="width: 8%" />
<col style="width: 3%" />
<col style="width: 8%" />
<col style="width: 8%" />
<col style="width: 3%" />
<col style="width: 8%" />
<col style="width: 8%" />
</colgroup>
<thead>
<tr class="header">
<th><strong>вход</strong></th>
<th><strong>изход</strong></th>
<th rowspan="2"></th>
<th><strong>вход</strong></th>
<th><strong>изход</strong></th>
<th rowspan="2"></th>
<th><strong>вход</strong></th>
<th><strong>изход</strong></th>
<th rowspan="2"></th>
<th><strong>вход</strong></th>
<th><strong>изход</strong></th>
<th rowspan="2"></th>
<th><strong>вход</strong></th>
<th><strong>изход</strong></th>
</tr>
<tr class="odd">
<th><p>100</p>
<p>99</p>
<p>80</p>
<p>70</p>
<p>Stop</p></th>
<th>70</th>
<th><p>-10</p>
<p>20</p>
<p>-30</p>
<p>Stop</p></th>
<th>-30</th>
<th><p>45</p>
<p>-20</p>
<p>7</p>
<p>99</p>
<p>Stop</p></th>
<th>-20</th>
<th><p>999</p>
<p>Stop</p></th>
<th>999</th>
<th><p>-1</p>
<p>-2</p>
<p>Stop</p></th>
<th>-2</th>
</tr>
</thead>
<tbody>
</tbody>
</table>

## 08\. Завършване

Напишете програма, която изчислява **средната оценка** на ученик от
цялото му обучение. На първия ред ще получите **името на ученика**, а на
всеки следващ ред неговите годишни оценки. Ученикът преминава в
следващия клас, **ако годишната му оценка е по-голяма или равна на
4.00**. **Ако ученикът бъде скъсан повече от един път, то той бива
изключен и програмата приключва,** като се отпечатва **името на ученика
и в кой клас бива изключен**.

При успешно завършване на **12-ти** клас да се отпечата :

"**{име на ученика} graduated. Average grade:** **{средната оценка от
цялото обучение}**"

**В случай, че ученикът е изключен от училище,** да се отпечата:

"**{име на ученика} has been excluded at {класа, в който е бил изключен}
grade**"

**Стойността трябва да бъде форматирана до втория знак** след
десетичната запетая.

### Примерен вход и изход

<table>
<colgroup>
<col style="width: 7%" />
<col style="width: 43%" />
<col style="width: 2%" />
<col style="width: 6%" />
<col style="width: 40%" />
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
<th><p>Gosho</p>
<p>5</p>
<p>5.5</p>
<p>6</p>
<p>5.43</p>
<p>5.5</p>
<p>6</p>
<p>5.55</p>
<p>5</p>
<p>6</p>
<p>6</p>
<p>5.43</p>
<p>5</p></th>
<th>Gosho graduated. Average grade: 5.53</th>
<th><p>Mimi</p>
<p>5</p>
<p>6</p>
<p>5</p>
<p>6</p>
<p>5</p>
<p>6</p>
<p>6</p>
<p>2</p>
<p>3</p></th>
<th>Mimi has been excluded at 8 grade</th>
</tr>
</thead>
<tbody>
</tbody>
</table>
