import { BrowserRouter as Router, Routes, Route } from "react-router-dom";

import MenuTop from "./components/MenuTop/MenuTop";
import Home from "./pages/Home";
import Client from "./pages/Client";
import Error from "./pages/Error";
import ClientDetail from "./pages/ClientDetail";

function App() {
  return (
    <Router>
      <MenuTop />
      <Routes>
        <Route path="/" element={<Home />} />
        <Route path="/client" element={<Client />} />
        <Route path="/client/:id" element={<ClientDetail />} />
        <Route path="*" element={<Error />} />
      </Routes>
    </Router>
  );
}

export default App;
