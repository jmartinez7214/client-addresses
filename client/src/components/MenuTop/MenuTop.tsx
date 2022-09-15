import { Menu } from "antd";
import { Link } from "react-router-dom";

import "./MenuTop.scss";

export default function MenuTop() {
  return (
    <Menu className="menu-top-web" mode="horizontal">
      <div>
        <Menu.Item key="logo" className="menu-top-web__logo">
          <Link to={"/"}>Company X</Link>
        </Menu.Item>
      </div>

      <div className="menu-top-web__right">
        <Menu.Item key="home" className="menu-top-web__item">
          <Link to="/">Home</Link>
        </Menu.Item>
        <Menu.Item key="client" className="menu-top-web__item">
          <Link to="/client">Clients</Link>
        </Menu.Item>
      </div>
    </Menu>
  );
}
