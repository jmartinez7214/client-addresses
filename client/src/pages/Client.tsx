import { Row, Col } from "antd";
import { FC } from "react";
import ClientsList from "../components/ClientsList/ClientsList";

const Client: FC = () => {
  return (
    <Row gutter={24}>
      <Col span={4} />
      <Col span={16}>
        <ClientsList />
      </Col>
      <Col span={4} />
    </Row>
  );
};

export default Client;
