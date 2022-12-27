export default function ClanListObj({id, br, ime, prezime, funkcije, vod, datumRodjenja, kategorija}) {

    const _datum = new Date(datumRodjenja);
    _datum.setMinutes(_datum.getMinutes() - _datum.getTimezoneOffset());

    return (
        <div className="row">
            <label style={{flex:"1", border:"none"}}>{br}.</label>
            <label>{ime} {prezime}</label>
            <label>{funkcije?.map(f => f.naziv).join(", ")}</label>
            <label>{vod?.naziv}</label>
            <label>{_datum.toLocaleDateString("sr", { year:"numeric", month:"2-digit", day:"2-digit" })}</label>
            <label>{kategorija?.replace("_", " ")}</label>
        </div>
    );
}