import { BrowserRouter, Route, Routes } from "react-router-dom";
import Menu from "./Components/Menu";
import Clanovi from "./Components/Clanovi/ListaClanova";
import Akcije from "./Components/Akcije";
import Tecajevi from "./Components/Tecajevi";
import "./Styles/App.css"

function App() {
  return (
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<Menu />}>
          <Route index element={<Clanovi />} />
          <Route path="akcije" element={<Akcije />} />
          <Route path="tecajevi" element={<Tecajevi />} />
        </Route>
      </Routes>
    </BrowserRouter>
  );
}

export default App;
