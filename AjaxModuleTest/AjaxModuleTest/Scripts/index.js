document.addEventListener("DOMContentLoaded", function () {
    loadStudents();
});

function loadStudents() {

    StudentModule.getStudents(function (Students) {
        setupStudentsTable(Students);
    });
       
    function setupStudentsTable(student) {
        
        for (i = 0 ; i < student.length; i++) {
            var row = document.createElement('tr');

            var lastnamecol = document.createElement('td');
            lastnamecol.innerHTML = student[i].LastName;
            row.appendChild(lastnamecol);

            var firstnamecol = document.createElement('td');
            firstnamecol.innerHTML = student[i].FirstMidName;
            row.appendChild(firstnamecol);

            var enrollmentdatecol = document.createElement('td');
            enrollmentdatecol.innerHTML = student[i].EnrollmentDate;
            row.appendChild(enrollmentdatecol);

            document.getElementById("studentsList").appendChild(row);

        };
    };
};