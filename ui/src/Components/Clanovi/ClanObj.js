import { useEffect, useState } from "react";
import { useNavigate, useParams } from "react-router";
import DeletionModal from "./DeletionModal";
import ShortObject from "./ShortObject";

export default function ClanObj() {
    const navigate = useNavigate();
    const params = useParams();
    let id = params.id;
    const [clan, setClan] = useState(null);
    const [modal, setModal] = useState(false);

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
        });
    }, [id]);


    function Delete(){
        fetch("https://localhost:7298/Clanovi/DeleteClan/" + id, {method: "DELETE"})
        .then (res => {
            if (res.status !== 200){
                alert("Trazeni clan nije pronadjen");
                return;
            }
            navigate(-1);
        })
    }
    

    if (!clan){
        return;
    }

    return(
    <div className="outlet"  >
        <button className="goBackButton" onClick={() => navigate(-1)}>←</button>
        <button className="deleteButton" onClick={() => setModal(true)}>Obrisi Clana</button>
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
                        {clan.akcije.map(x => <ShortObject id={x.id} naziv={x.naziv} path={"akcija"} />)}
                    </div>
                </div>
                <div>
                    <label>Tecajevi</label>
                    <div className="objListing">
                        <label>1</label>
                        <label>2</label>
                        <label>3</label>
                        <label>4</label>
                        <label>5</label>
                        <label>6</label>
                        <label>7</label>
                        <label>8</label>
                        <label>9</label>
                        <label>10</label>
                        <label>11</label>
                        <label>12</label>
                        <label>13</label>
                    </div>
                </div>
            </div>
            <div className="gridRow">
                <div>
                    <label>Poseban program</label>
                    <div className="objListing">
                        
                    </div>
                </div>
                <div>
                    <label>Znanja</label>
                    <div className="objListing">

                    </div>
                </div>
            </div>
            <div className="gridRow">
                <div>
                    <label>Pohvale</label>
                    <div className="objListing">

                    </div>
                </div>
                <div>
                    <label>Kazne</label>
                    <div className="objListing">

                    </div>
                </div>
            </div>
            <div className="gridRow" style={{margin: "0 25%"}}>
                <div>
                    <label>Placene Clanarine</label>
                    <div className="objListing">

                    </div>
                </div>
            </div>
        </div>
        <DeletionModal message={`Da li ste sigurni da zelite da obrisete clana '${clan.ime} ${clan.prezime}'?`} modal={modal}
            setModal={setModal} ok={Delete} />
    </div>); 
    //Dodati onClick za labelu sa vodom ... kad napravim vodove ffs
}