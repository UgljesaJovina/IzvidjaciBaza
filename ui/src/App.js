import { BrowserRouter, Route, Routes } from "react-router-dom";
import Menu from "./Components/Menu";
import Clanovi from "./Components/Clanovi/ClanList";
import Akcije from "./Components/Akcije";
import Tecajevi from "./Components/Tecajevi";
import "./Styles/Menu.css"
import "./Styles/Table.css"
import "./Styles/Modal.css"
import "./Styles/ClanViewPage.css"
import ClanObj from "./Components/Clanovi/ClanObj";

function App() {
  return (
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<Menu />}>
          <Route index element={<Clanovi />} />
          <Route path="akcije" element={<Akcije />} />
          <Route path="tecajevi" element={<Tecajevi />} />
          <Route path="clan/:id" element={<ClanObj />}/>
        </Route>
      </Routes>
    </BrowserRouter>
  );
}

export default App;
