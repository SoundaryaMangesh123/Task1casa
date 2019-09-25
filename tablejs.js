


$(document).ready(function() {
    var t = $('#example').DataTable();
	var t1 = $('#example1').DataTable();
    var counter = 1;
    
    $('#addRow').on( 'click', function () {
	var x = document.getElementById("myText").value;
	var y = document.getElementById("myText1").value;
	var z = document.getElementById("myText2").value;
	var x1 = document.getElementById("myText11").value;
	var y1 = document.getElementById("myText12").value;
	
        t.row.add( [
            counter +'.1',
            x,
			y,
			z,
            "hello",
            counter +'.4',
            counter +'.5'
        ] ).draw( false );
		t1.row.add( [
            counter +'.1',
            x1,
			y1,
			z,
            "hello",
            counter +'.4',
            counter +'.5'
        ] ).draw( false );
 
        counter++;
    } );
 
    // Automatically add a first row of data
    $('#addRow').click();
} );