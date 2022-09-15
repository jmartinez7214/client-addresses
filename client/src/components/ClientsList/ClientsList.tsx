import { Spin, List, Button } from "antd";
import { Link } from "react-router-dom";
import { Client } from "../../types";

import "./ClientsList.scss";
import useClients from "../../hooks/useClients";

const ClientsList = () => {
  const { clients } = useClients();

  if (!clients) {
    return (
      <Spin tip="Loading..." style={{ width: "100%", padding: "200px 0" }} />
    );
  }

  return (
    <>
      <div className="address-list-web">
        <h1>Clients</h1>
        <List
          dataSource={clients}
          renderItem={(client) => <ClientPost client={client} />}
        />
      </div>
    </>
  );
};

interface ClientPostInterface {
  client: Client;
}

const ClientPost = ({ client }: ClientPostInterface) => {
  return (
    <>
      <List.Item
        actions={[
          <Link to={`/client/${client.id}`} target="_blank">
            <Button type="primary">
              <span>View Client</span>
            </Button>
          </Link>,
        ]}
      >
        <List.Item.Meta
          title={`Client Name: ${client.firstName} ${client.lastName}`}
        />
      </List.Item>
      <hr />
    </>
  );
};

export default ClientsList;
