import { Spin, List } from "antd";
import { Address } from "../../types";

import "./ClientsDetail.scss";
import useClient from "../../hooks/useClient";
import useClientAddresses from "../../hooks/useClientAddresses";

const ClientsDetail = () => {
  const { client } = useClient();
  const { clientAddresses } = useClientAddresses();

  if (!client || !clientAddresses) {
    return <Spin tip="Loading" style={{ width: "100%", padding: "200px 0" }} />;
  }

  return (
    <>
      <h1 style={{ textAlign: "center" }}>
        Client Name: {client?.firstName} {client?.lastName}
      </h1>

      <div>
        <h2 style={{ marginLeft: "20px" }}>Addresses:</h2>
        <List
          dataSource={clientAddresses}
          renderItem={(address) => <AddressPost address={address} />}
        />
      </div>
    </>
  );
};

interface AddressPostInterface {
  address: Address;
}

const AddressPost = ({ address }: AddressPostInterface) => {
  return (
    <>
      <List.Item>
        <List.Item.Meta title={`Address: ${address.address}`} />
      </List.Item>
    </>
  );
};

export default ClientsDetail;
