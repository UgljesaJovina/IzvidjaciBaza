import { useEffect, useState } from "react";
import { useNavigate, useParams } from "react-router";
import ShortAkcija from "../ShortObjects/ShortAkcija";

export default function ClanObj() {
    const navigate = useNavigate();
    const params = useParams();
    let id = params.id;
    const [clan, setClan] = useState({});

    useEffect(() => {
        fetch("https://localhost:7298/Clanovi/GetClan/" + id)
        .then (res => {
            if (res.status !== 200){
                alert("Trazeni clan nije pronadjen");
                return;
            }
            return res.json();
        }).then(data => {
            setClan(data);
            console.log(data);
        });
    }, [id]);

    return(
    <div className="outlet">
        <button className="goBackButton" onClick={() => navigate(-1)}>←</button>
        <h1 className="name">{clan.ime} {clan.prezime}</h1>
        <h2 className="category"><i>{clan.kategorija ? clan.kategorija.replace("_", " ") : "Nema" }</i></h2>
        <div className="viewGrid">
            <div className="gridRow info">
                <div>
                    <h2>Informacije o clanu:</h2>
                    <label>Adresa: {clan.adresa ? clan.adresa : <span>Nije uneta</span>}</label>
                    <label>Telefon: {clan.telefon ? clan.telefon : <span>Nije unet</span>}</label>

                    <label>Datum Rodjenja: {new Date(clan.datumRodjenja).toLocaleDateString("sr",
                        { year:"numeric", month:"2-digit", day:"2-digit" })}</label>

                    <label>Datum Uclanjenja: {new Date(clan.datumUclanjenja).toLocaleDateString("sr",
                        { year:"numeric", month:"2-digit", day:"2-digit" })}</label>

                    <label>Datum Davanja Zaveta: {clan.datumZaveta ? new Date(clan.datumZaveta).toLocaleDateString("sr",
                        { year:"numeric", month:"2-digit", day:"2-digit" }) : <span>Nema</span>}</label>
                    
                    <label>Funkcije: {Array.isArray(clan.funkcije) && clan.funkcije.length ? clan.funkcije.join(", ") : <span>Nema</span>}</label>
                    <label style={{marginBottom: "20px"}}>Vod: {clan.vod ? clan.vod : <span>Nema</span>}</label>
                </div>
            </div>
            <div className="gridRow">
                <div>
                    <label>Akcije</label>
                    <div className="objListing">
                        {clan.akcije.map(x => <ShortAkcija id={x.id} naziv={x.naziv} />)}
                    </div>
                </div>
                <div>
                    <label>Tecajevi</label>
                    <div className="objListing">

                    </div>
                </div>
            </div>
        </div>
    </div>); //Dodati onClick za labelu sa vodom ... kad napravim vodove ffs
}