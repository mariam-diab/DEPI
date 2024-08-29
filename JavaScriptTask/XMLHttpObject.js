var request = new XMLHttpRequest();
var url = 'https://jsonplaceholder.typicode.com/posts';
request.onreadystatechange = function myfunction() {
    if (request.readyState == 4 && request.status == 200) {
        var resData = JSON.parse(request.responseText);
        consuming(resData);
        showData();


    }

};
request.open('GET', url, true);
request.send();
var result = document.createElement('tbody');
function consuming(data) {
    for (var item of data) {
        var row = document.createElement('tr');

        var cellUserID = document.createElement('td');
        cellUserID.textContent = item.userId;
        row.appendChild(cellUserID);

        var cellID = document.createElement('td');
        cellID.textContent = item.id;
        row.appendChild(cellID);

        var cellTitle = document.createElement('td');
        cellTitle.textContent = item.title; 
        row.appendChild(cellTitle);

        var cellBody = document.createElement('td');
        cellBody.textContent = item.body;
        row.appendChild(cellBody);

        result.appendChild(row);
    }
};

function showData() {
    document.getElementById('jsonTable').appendChild(result);

}