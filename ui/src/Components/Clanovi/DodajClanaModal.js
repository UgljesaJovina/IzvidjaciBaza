export default function DodajClana({modal, setModal, fetchClanovi}){

    let ime, prezime, datumRodjenja, datumUclanjenja, datumZaveta, adresa, kategorija;

    function dodajClana(){

        if (ime.value === "" || prezime.value === "" || datumRodjenja.value === "" || datumUclanjenja.value === ""){
            alert("Neka polja nisu uneta kako treba!");
            return;
        }

        const options = {
            method: "POST", 
            headers: {
                'Content-Type' : 'application/json'
            },
            body: JSON.stringify({
                ime: ime.value,
                prezime: prezime.value,
                datumRodjenja: datumRodjenja.value,
                datumUclanjenja: datumUclanjenja.value,
                datumZaveta: datumZaveta.value === "" ? null : datumZaveta.value,
                adresa: adresa.value === "" ? null : adresa.value,
                kategorija: kategorija.value === "" ? null : parseInt(kategorija.value)
            })
        };

        fetch("http://localhost:5246/Clanovi/CreateClan", options)
        .then (res => {
            if (res.status !== 200) {
                alert("Problem sa upisivanjem");
            }else {
                ime.value = "";
                prezime.value = "";
                datumRodjenja.value = "";
                datumUclanjenja.value = "";
                datumZaveta.value = "";
                adresa.value = "";
                kategorija.value = "";
            }
            setModal(false);
            fetchClanovi();
            return res.json();
        }).then(data => console.log(data))
    }

    return (
        <div className={`modal ${modal ? "show" : ""}`}>
            <div className="shade" onClick={() => setModal(false)}></div>
            <div className="form" style={{display:"flex", flexDirection:"column"}}>
                <h2>Dodaj Clana</h2>
                <div>
                    <label className="required" htmlFor="ime">Ime: </label>
                    <input id="ime" name="ime" type="text" ref={el => ime = el} />
                </div>
                <div>
                    <label className="required" htmlFor="prezime">Prezime: </label>
                    <input id="prezime" name="prezime" type="text" ref={el => prezime = el} />
                </div>
                <div>
                    <label className="required" htmlFor="datumRodjenja">Datum Rodjenja: </label>
                    <input id="datumRodjenja" name="datumRodjenja" type="date" ref={el => datumRodjenja = el} />
                </div>
                <div>
                    <label className="required" htmlFor="datumUclanjenja">Datum Uclanjenja: </label>
                    <input id="datumUclanjenja" name="datumUclanjenja" type="date" ref={el => datumUclanjenja = el} />
                </div>
                <div>
                    <label htmlFor="datumZaveta">Datum Davanja Zaveta: </label>
                    <input id="datumZaveta" name="datumZaveta" type="date" ref={el => datumZaveta = el} />
                </div>
                <div>
                    <label htmlFor="adresa">Adresa: </label>
                    <input id="adresa" name="adresa" type="text" ref={el => adresa = el} />
                </div>
                <div>
                    <label htmlFor="kategorija">Kategorija: </label>
                    <select id="kategorija" name="kategorija" defaultValue="" ref={el => kategorija = el}>
                        <option value="" disabled hidden>Izaberite Kategoriju</option>
                        <option value={0}>Poletarci</option>
                        <option value={1}>Pcelice</option>
                        <option value={2}>Mladji Izvidjaci</option>
                        <option value={3}>Mladje Planinke</option>
                        <option value={4}>Stariji Izvidjaci</option>
                        <option value={5}>Starije Planinke</option>
                        <option value={6}>Brdjani</option>
                        <option value={7}>Brdjanke</option>
                    </select>
                </div>
                <button onClick={dodajClana}>Dodaj Clana</button>
            </div>
        </div>
    );
}