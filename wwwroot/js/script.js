// Script for calculating Grades
//let submit = document.getElementById('submit');

let A_WEIGHT = 0.5;
let E_WEIGHT = 0.2;
let GP_WEIGHT = 0.1;
let Q_WEIGHT = 0.1;
let I_WEIGHT = 0.1;

$('#submit').click(function () {
    let asgn = parseFloat($('#asgn').val());
    let grpProj = parseFloat($('#gp').val());
    let ex = parseFloat($('#ex').val());
    let qz = parseFloat($('#qz').val());
    let intex = parseFloat($('#in').val());

    //Calculate grades
    let total = ((asgn) * A_WEIGHT) + ((grpProj) * GP_WEIGHT) + ((ex) * E_WEIGHT) + ((qz) * Q_WEIGHT) + ((intex) * I_WEIGHT);

    //Assign letter grades
    let letterGrade = "";
    if (total < 60.00) {
        letterGrade = 'E';
    } else if (total < 64) {
        letterGrade = 'D-';
    } else if (total < 67) {
        letterGrade = 'D';
    } else if (total < 70) {
        letterGrade = 'D+';
    } else if (total < 74) {
        letterGrade = 'C-';
    } else if (total < 77) {
        letterGrade = 'C';
    } else if (total < 80) {
        letterGrade = 'C+';
    } else if (total < 84) {
        letterGrade = 'B-';
    } else if (total < 87) {
        letterGrade = 'B';
    } else if (total < 90) {
        letterGrade = 'B+';
    } else if (total < 94) {
        letterGrade = 'A-';
    } else {
        letterGrade = 'A';
    };

    alert("Total Grade: " + total + "% [" + letterGrade + "]")
    //Display Grade
    $('#totalScore').innerHTML = total + '%';
    $('#letterGrade').innerHTML = '[' + letterGrade + ']';
})


