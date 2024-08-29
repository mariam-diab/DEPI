var request = new XMLHttpRequest();
var url = 'https://localhost:44375/Courses.txt';
request.onreadystatechange = function myfunction() {
    if (request.readyState == 4 && request.status == 200) {
        var resData = JSON.parse(request.responseText);
        consuming(resData);


    }

};
request.open('GET', url, true);
request.send();
var result = document.createElement('ol');
function consuming(data) {
    for (var item of data.Courses) {
        var listitem = document.createElement('li');
        listitem.innerHTML = 'Course Name: ' + item.CourseName + ' - Price: ' + item.Price;
        result.appendChild(listitem);
    }
};

function showData() {
    document.getElementById('mylist').appendChild(result);

}