function CargaDatos()
{
    $table.bootstrapTable('refreshOptions', {
        showColumns: true,
        search: true,
        showRefresh: true,
        url: '/Socios/GetData'
    });
}