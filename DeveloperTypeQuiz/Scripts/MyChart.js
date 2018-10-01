draw = function (frontEnsScore, backEndScore)
{
    //var bE = parseInt(backEndScore);
    //var fE = parseInt(frontEnsScore);

    var bE = parseFloat(backEndScore);
    var fE = parseFloat(frontEnsScore);

    google.charts.load('current', { packages: ['corechart'] });
    google.charts.setOnLoadCallback(drawChart);


    function drawChart()
    {

        // Define the chart to be drawn.


        var data = new google.visualization.DataTable();
        data.addColumn('string', 'Element');
        data.addColumn('number', 'Percentage');
        data.addRows([
          ['Front End', fE],
        
          ['Back End', bE]
        ]);




        var options = {
            'width': 400, 'height': 300, 'backgroundColor': 'transparent', series: {
                0: { color: 'red' },
                1: { color: 'yellow' }
            }
        };




    var chart = new google.visualization.PieChart(document.getElementById('resultsChart'));

    chart.draw(data, options);


    }


}