# SqrLib

<br>Считает площадь круга, эллипса, квадрата, прямоугольника , треугольника, и Правильного многоугольника</br>
<b>SqrLib</b> библиотека которая подчитывает площадь некоторых фигур. 
 

Метод <b>GetArea(float[] sides)</b> принимает в параметр массив типа float(все значения должны быть положительны), где каждое значение это длинна. 
В зависимости от длинный массива он вернут площадь фигуры 
<br><b>Круг</b> - рассчитывается по <b>1</b> значению, Радиуса 
<br><b>Эллипс</b> - рассчитывается по <b>2</b> значениям (короткий и длинный радиус) 
<br><b>Треугольник</b> - рассчитывается по <b>3</b> сторонам 
<br><b>Квадрат</b> и  Прямоугольник - по <b>4</b> сторонам 
<br><b>Правильный многоугольник</b> (где все стороны и углы равны) - если массив содержит <b>более 4х сторон</b> и эти стороны равны вернёт площадь многоугольника 

Все эти фигуры обобщены тем, что высчитываются, зная их стороны или радиус. Для, добавления, подсчета иных фигур, где необходимо знать не только стороны, но еще и высоту или угол. Необходимо будет создавать отдельные методы. Которые принимаю не только длины, но еще и углы. 
 
Так же в библиотеке содержится метод  <b>IsSectangular(float a, float b, float c)</b> который принимает в параметр три длины. Метод Вернет является ли это треугольник прямым или равнобедренным, и  может ли существовать такой треугольник. 


<b>Тесты расположенны в этом же репезитории</b>
