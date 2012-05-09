Sys.Application.add_init(function MostrarCalendario () {
    $create(Sys.Extended.UI.CalendarBehavior, { "button": $get("CalendarioInicio"), "id": "CalendarioInicioExtender" }, null, null, $get("IndexTextFechaInicio"));
});
