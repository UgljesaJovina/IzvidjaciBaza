import { useNavigate } from "react-router";

export default function ClanListObj({id, br, ime, prezime, funkcije, vod, datumRodjenja, kategorija}) {

    const navigate = useNavigate();
    const _datum = new Date(datumRodjenja);
    _datum.setMinutes(_datum.getMinutes() - _datum.getTimezoneOffset());

    return (
        <div className="row" onClick={() => navigate(`clan/${id}`)}>
            <label style={{flex:"1", border:"none"}}>{br}.</label>
            <label>{ime} {prezime}</label>
            <label>{funkcije ? funkcije.map(f => f.naziv).join(", ") : <span>Nema</span> }</label>
            <label>{vod ? vod.naziv : <span>Nema</span> }</label>
            <label>{_datum.toLocaleDateString("sr", { year:"numeric", month:"2-digit", day:"2-digit" })}</label>
            <label>{kategorija ? kategorija.replace("_", " ") : <span>Nema</span> }</label>
        </div>
    );
}