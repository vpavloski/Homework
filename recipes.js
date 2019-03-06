/* For example:
http://www.recipepuppy.com/api/?i=onions,garlic&q=omelet&p=3 

Optional Parameters:
i : comma delimited ingredients
q : normal search query
p : page
format=xml : if you want xml instead of json  */


// let apiEndPoint = 'http://www.recipepuppy.com/api/?';
let apiEndPoint = 'http://jsonplaceholder.typicode.com/';
let apiResponse;

$("document").ready(function() { //se osiguruvame deka site src scripti se vekje vcitani
    getToDos();
   
});

function getToDos()
{
    let uri = "todos";
    $.ajax({
        url: apiEndPoint + uri, 
            
        //url: http://www.recipepuppy.com/api//?i=onion
        //'http://jsonplaceholder.typicode.com/"
        method: "GET",
        dataType: "json",
        success: function(data){
           // console.log(data);
           printTodos(data);
           // apiResponse !!! ovde prestanav da PISUVAM !!!!! 
        },
        error: function(e){
            console.log(e);
        }
    })
}
function printTodos(listOfTodos){
    for (let i=0, ilen = listOfTodos.length; i<ilen; i++){
        //for (let i=0; i<listOfTodos.length; i++)   --- isto kako pogore, ama posigurno e prvoto za da ne se sluci pri ciklusot da se smeni vrednosta za dolzina na nizata

        $("#existingTodos > ul").append('<li> <span>userId: ' + listOfTodos[i].userId +'</span><span> title: ' +listOfTodos[i].title +',</span><span class="complete-'+listOfTodos[i].completed+'">completed: '+listOfTodos[i].completed+ '</span> </li>');
    }
    $("#existingTodos > ul > li > span.complete-true").on('click', function(e) {
        //let status = $(this).text();
        $(this).removeClass('complete-true');
        $(this).addClass('complete-false');
    })
    $("#existingTodos > ul > li > span.complete-false").on('click', function(e) {
        //let status = $(this).text();
        $(this).removeClass('complete-false');
        $(this).addClass('complete-true');
    })
}
