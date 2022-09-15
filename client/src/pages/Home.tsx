import { Button } from "antd";
import { FC } from "react";
import { Link } from "react-router-dom";

const Home: FC = () => {
  return (
    <div style={{ textAlign: "center" }}>
      <h1>Welcome to the Company X</h1>

      <h3>Here you can find information about our clients.</h3>

      <Link to="/client">
        <Button type="primary">Go To Clients Page</Button>
      </Link>
    </div>
  );
};

export default Home;
