function getBirth(nationalid, birthdate) {
    var nid = document.getElementById(nationalid).value;
    var birth = document.getElementById(birthdate);
    var year = nid.slice(1, 3);
    var month = nid.slice(3, 5);
    var day = nid.slice(5, 7);
    if (nid.slice(0, 1) == '1') {
        birth.value = month + '/' + day + '/' + '18' + year;
    }
    else if (nid.slice(0, 1) == '2') {
        birth.value = month + '/' + day + '/' + '19' + year;
    }
    else if (nid.slice(0, 1) == '3') {
        birth.value = month + '/' + day + '/' + '20' + year;
    }
    
}

function getName(full, first, last) {
    var fullname = document.getElementById(full).value;
    var firstname = document.getElementById(first);
    var lastname = document.getElementById(last);
    var sp1 = fullname.indexOf(' ');
    var sp2 = fullname.lastIndexOf(' ');
    firstname.value = fullname.slice(0, sp1);
    lastname.value = fullname.slice(sp2 + 1);




}