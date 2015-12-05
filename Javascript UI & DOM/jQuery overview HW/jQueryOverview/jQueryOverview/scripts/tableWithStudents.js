var $students = [
           {
               firstName: 'Georgi',
               lastName: 'Georgiev',
               grade: '3'
           },
           {
               firstName: 'Peter',
               lastName: 'Ivanov',
               grade: '5'
           },
           {
               firstName: 'Ivan',
               lastName: 'Grigorov',
               grade: '7'
           }];

var $information = '';
for (var i = 0; i < $students.length; i++) {
    $information += '<tr>' +
                  '<td>' + $students[i].firstName + '</td>' +
                  '<td>' + $students[i].lastName + '</td>' +
                  '<td>' + $students[i].grade + '</td>' +
                  '</tr>';
}

var $table = $('<table>' +
             '<tr>' +
             '<th>First Name</th>' +
             '<th>Second Name</th>' +
             '<th>Grade</th>' +
             '</tr>' + $information +
             '</table>');

var $container = $('#container')
$container.append($table);