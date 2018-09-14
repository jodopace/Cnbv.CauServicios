

//function AsignFolioToPerson()
//{
//    debugger;
//    $.ajax({
//        type: "POST",
//        url: '@Url.Action("AsignNewFolio", "AsignarFolios")',
//        contentType: "application/json; charset=utf-8",
//        dataType: "json",
//        data: { folio: $('#folioInTxt').val() },
//        success: function (chData) {

        
//        },
//        error: function (xhr, ajaxOptions, thrownError) {
//            alert(xhr.status);
//            alert(thrownError);
//        }
//    });
//}




function LoadChart(url) {
    debugger;
    $.ajax({
        type: "POST",
        url: url,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (chData) {
          
            var aData = chData;
            console.log(aData);
            var aLabels = aData[0];
            console.log(aLabels);
            var aDatasets1 = aData[1];
            var aDataColors = aData[2];
            
            var dataT = {
                labels: aLabels,
                datasets: [{
                    label: "Solicitudes Asignadas",
                    data: aDatasets1,
                    fill: false,
                    backgroundColor:aDataColors,                   
                    ///borderColor: ["rgb(54, 162, 235)", "rgb(255, 99, 132)", "rgb(255, 159, 64)", "rgb(255, 205, 86)", "rgb(75, 192, 192)", "rgb(153, 102, 255)", "rgb(201, 203, 207)"],
                    borderWidth: 1
                }]
            };


            'use strict'

            var ticksStyle = {
                fontColor: '#495057',
                fontStyle: 'bold',
                autoSkip: false
            }

            var mode = 'index'
            var intersect = true

            var $FolioIngChart = $('#FolioIng-chart')


            var FolioIngChart = new Chart($FolioIngChart, {
                type: 'bar',
                data: dataT,               
                options: {
                    maintainAspectRatio: false,
                    tooltips: {
                        mode: mode,
                        intersect: intersect
                    },
                    hover: {
                        mode: mode,
                        intersect: intersect
                    },
                    legend: {
                        display: false
                    },
                    scales: {
                        yAxes: [{
                            // display: false,
                            gridLines: {
                                display: true,
                                /////lineWidth: '4px',
                                color: 'rgba(0, 0, 0, .2)',
                                zeroLineColor: 'transparent'
                            },
                            ticks: $.extend({
                                beginAtZero: true,

                                // Include a dollar sign in the ticks
                                callback: function (value, index, values) {
                                    if (value >= 1000) {
                                        value /= 1000
                                        value += 'k'
                                    }
                                    return '' + value
                                }
                            }, ticksStyle)
                        }],
                        xAxes: [{
                            display: true,
                            gridLines: {
                                display: true
                            },
                            ticks: ticksStyle
                        }]
                    }
                }
            })

        },
        error: function (xhr, ajaxOptions, thrownError) {
            alert(xhr.status);
            alert(thrownError);
        }        
    })

}
