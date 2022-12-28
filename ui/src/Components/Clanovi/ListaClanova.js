import { useEffect, useState } from "react";
import ClanListObj from "./ClanListObj";
import DodajClana from "./DodajClanaModal";

export default function Clanovi() {

    const [clanovi, setClanovi] = useState([]);
    const [modal, setModal] = useState(false);

    function fetchClanovi(){
        fetch("https://localhost:7298/Clanovi/ClanoviList")
        .then(res => res.json())
        .then(data => setClanovi(data));
    }

    useEffect(() => {
        fetchClanovi();
    }, []);

    return (
        <div className="outlet">
            <button className="addBtn" onClick={() => {setModal(curr => !curr)}}>Dodaj Clana</button>
            <div className="table">
                <div className="row initial">
                    <label style={{flex:"1", border:"none"}}>Br.</label>
                    <label>Ime i Prezime</label>
                    <label>Funckije</label>
                    <label>Vod</label>
                    <label>Datum Rodjenja</label>
                    <label>Kategorija</label>
                </div>
                {clanovi.map((el, i) => <ClanListObj key={el.id} id={el.id} br={i+1} ime={el.ime} prezime={el.prezime} 
                    vod={el.vod} datumRodjenja={el.datumRodjenja} kategorija={el.kategorija} />)}
            </div>
            <DodajClana modal={modal} setModal={setModal} fetchClanovi={fetchClanovi} />
        </div>
    );
}