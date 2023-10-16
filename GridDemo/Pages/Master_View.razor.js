const html = window.igTemplating.html;
let northwindEmployeesEmployeeTitles = [];

igRegisterScript("columnBodyTemplateScript", (ctx) => {
    return html`
        <div master-view-scope class="row-layout group">
            <igc-avatar .src="${ctx.cell.row.data['Employee'].PhotoPath}" size="large" master-view-scope shape="circle" class="avatar"></igc-avatar>
            <p master-view-scope class="typography__body-2 text">
                ${ctx.cell.row.data['Employee'].TitleOfCourtesy}
            </p>
            <p master-view-scope class="typography__body-2 text">
                ${ctx.cell.row.data['Employee'].FirstName}
            </p>
            <p master-view-scope class="typography__body-2 text">
                ${ctx.cell.row.data['Employee'].LastName}
            </p>
        </div>
    `
}, false);
igRegisterScript("columnInlineEditorTemplateScript", (ctx) => {
    return html`
        <igc-combo ?outlined="${true}" .data="${northwindEmployeesEmployeeTitles}" value-key="title" display-key="title" master-view-scope ?single-select="${true}" class="single-select-combo"></igc-combo>
    `
}, false);
igRegisterScript("columnBodyTemplateScript1", (ctx) => {
    return html`
        <div master-view-scope class="column-layout group_1">
            <p master-view-scope class="typography__body-2 text">
                ${ctx.cell.value}
            </p>
            <div master-view-scope class="row-layout group_2">
                <p master-view-scope class="typography__caption text">
                    ${ctx.cell.row.data['Employee'].City}
                </p>
                <p master-view-scope class="typography__caption text">
                    ${ctx.cell.row.data['Employee'].Country}
                </p>
            </div>
        </div>
    `
}, false);
igRegisterScript("columnBodyTemplateScript2", (ctx) => {
    return html`
        <igc-chip master-view-scope size="large" class="chip">
            <span master-view-scope slot="prefix">
                <span master-view-scope class="material-icons icon">
                    call
                </span>
            </span>
            ${ctx.cell.value}
        </igc-chip>
    `
}, false);

window.transferMaster_View = (view) => {
    northwindEmployeesEmployeeTitles = view.northwindEmployeesEmployeeTitles;
}
